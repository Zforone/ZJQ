using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // const string name = "曾俊清";
           // string clause = "爱学习，一天不学习就浑身难受！";
           // Console.WriteLine(name + clause);
           // //Console.ReadLine();
           // //在“入栈口号”的基础上，
           // //使用变量Age（年龄）、IsFemale（是否男生）、Height（身高，单位米）、FromCity（来自哪里）存储你的个人信息，
           // //并在控制台逐行输出
           // //输出两个整数 / 小数的和 / 差 / 积 / 商
           // int Age = 22;
           // bool IsFemale = false;
           // double Height = 1.65;
           // string FromCity = "江西";
           // Console.WriteLine("年龄: " + Age + "\n是否男生：" + IsFemale + "\n身高：" + Height + "米" + "\n来自: " + FromCity);
           //// Console.ReadLine();
           // int i = 30 , j = 20;
           // Console.WriteLine("\n整数");
           // Console.WriteLine("和：" + (i+j)+ "\n差："+ (i-j)+ "\n积："+(i*j)+"\n商:"+(i/ (float)j));
           // double m = 9.99, n = 1.11;
           // Console.WriteLine("\n小数");
           // Console.WriteLine("和：" + (m + n) + "\n差：" + (m - n) + "\n积：" + (m * n) + "\n商:" + (m / n));
           // Console.ReadLine();
            //输入一个字符，显示这个字符的unicode值
            //输入一个整数，如果这个整数：
            //能被6整除，显示：六六顺
            //能被8整除，显示：发发发
            //否则，显示：大吉大利
            char unicode = '帅';
            Console.WriteLine(unicode);
            
            int i = 24;  //48,55,1,12,16,-2,-6,-8,-51
            if ((i % 6) == 0 && (i % 8) == 0)
            {
                Console.WriteLine("厉害厉害！");
            }
            else if ((i % 6) != 0 && (i % 8) != 0)
            {
                Console.WriteLine("大吉大利!");
            }
            else if (i % 6 == 0)
            {
                Console.WriteLine("六六顺!");
            }
            else if (i % 8 == 0)
            {
                Console.WriteLine("发发发!");
            }
            else
            {
                //不做任何事
            }
            

           

        }
    }
}
