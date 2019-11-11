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
            //char unicode = '帅';
            //Console.WriteLine((int)unicode);


            //24("厉害厉害！"),55("大吉大利!"),1("大吉大利!"),12("六六顺!"),16("发发发!"),
            //-2("大吉大利!"),-6("六六顺!"),-8("发发发!"),-51("大吉大利!")

            //int i = 24;  
            //if ((i % 6) == 0 && (i % 8) == 0)
            //{
            //    Console.WriteLine("厉害厉害！");
            //}
            //else if ((i % 6) != 0 && (i % 8) != 0)
            //{
            //    Console.WriteLine("大吉大利!");
            //}
            //else if (i % 6 == 0)
            //{
            //    Console.WriteLine("六六顺!");
            //}
            //else if (i % 8 == 0)
            //{
            //    Console.WriteLine("发发发!");
            //}
            //else
            //{
            //    //不做任何事
            //}

            //将源栈同学姓名 / 昵称分别：
            //按进栈时间装入一维数组，
            //按座位装入二维数组，
            //并输出共有多少名同学
            string[] studentName = { "王新", "陈百万", "阿泰" };
            Console.WriteLine(studentName.Length);
            Console.WriteLine(studentName[0] + "," + studentName[1] + "," + studentName[2]);
            string[,] studentNumber = {
                { "于维谦", "彭志强", "陈百万" },
                { "赵敬春", "王新", "刘江平" } ,
                { "幸龙泰", "曾俊清", "杨进文" }
            };
            Console.WriteLine(studentNumber.Length);
            Console.WriteLine(studentNumber[2, 1]);


            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            for (int forNum = 1; forNum < 6;)
            {
                Console.WriteLine(forNum);
                forNum++;
            }
            int whileNum = 1;
            while (whileNum < 10)
            {
                Console.WriteLine(whileNum);
                whileNum += 2;
            }
            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            for (int for1d = 0; for1d < studentName.Length;)
            {
                Console.WriteLine(studentName[for1d]);
                for1d++;
            }
            int rowLength = studentNumber.GetLength(0);
            int colunmLength = studentNumber.GetLength(1);
            for (int for2DRow = 0; for2DRow < rowLength;)
            {
                for (int for2DColunm = 0; for2DColunm < colunmLength;)
                {
                    Console.WriteLine(studentNumber[for2DRow, for2DColunm]);
                    for2DColunm++;
                }
                for2DRow++;
            }

            //让电脑计算并输出：99 + 97 + 95 + 93 +...+ 1的值
            int sun = 0;
            for (int sunNum = 99; sunNum > 0;)
            {

                //Console.WriteLine(sunNum );
                sun += sunNum;
                sunNum -= 2;
            }
            Console.WriteLine(sun);
            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            double[] score = { 98, 78, 88.5, 86, 99, 75, 92.5, 75 };
            double maxScore;
            if (score[0] > score[1])
            {
                maxScore = score[0];
            }
            else
            {
                maxScore = score[1];
            }
            for (int i = 0; i < score.Length - 1;)
            {
                double j = score[i + 1];
                if (maxScore < j)
                {
                    maxScore = j;
                }
                else
                {
                    //nothing
                }
                i++;
            }
            Console.WriteLine(maxScore);

            //找到100以内的所有质数（只能被1和它自己整除的数）

            Console.WriteLine(1);
            Console.WriteLine(2);
            for (int n = 1; n < 100; n++)
            { 
                for (int m = 2; m < n; m++)
                {
                    if (n % m == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (n - 1 == m)
                        {
                            Console.WriteLine(n);
                        }
                        else
                        {
                            //nothing
                        }
                    }
                   
                }  
            }
            Console.ReadLine();
        }
    }
}
