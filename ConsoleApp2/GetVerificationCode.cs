using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class GetVerificationCode
    {
        //参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
        //随机字符串
        //混淆用的各色像素点
        //混淆用的直线（或曲线）
        public static void GetImage()
        {
            string[] slogans = {"A","B" ,"C","D","E","F","G"};
            string slogan = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int randomNum = random.Next(6);
                slogan += slogans[randomNum];
            }
            Bitmap image = new Bitmap(200, 200);
            Graphics g = Graphics.FromImage(image);
            Font font = new Font("宋体", 18);
            PointF pointF = new PointF(80, 80);

            g.Clear(Color.AliceBlue);
            for (int i = 0; i < 10; i++)
            {                 
                int x = random.Next(80, 130);
                int y = random.Next(80, 130);
                int z = random.Next(80, 130);
                g.DrawLine(new Pen(Color.Blue), new Point(x, y), new Point(y, z));
                g.DrawLine(new Pen(Color.Yellow), new Point(x, z), new Point(z, y));
                PointF[] points = { new PointF(x, y), new PointF(x, z), new PointF(y, z) };
                g.DrawCurve(new Pen(Color.Red), points);
            }
            
            g.DrawString(slogan,
                font,
                new SolidBrush(Color.Red),
                pointF
            );
            for (int i = 0; i < 100; i++)
            {
                int X = random.Next(50,150);
                int Y = random.Next(50, 150);
                image.SetPixel(X, Y, Color.Red);
                image.SetPixel(Y, X, Color.Yellow);                
            }
            image.RotateFlip(RotateFlipType.Rotate180FlipX);
            image.Save(@"E:\17bang3.jpg", ImageFormat.Jpeg);
        }
    }
}
