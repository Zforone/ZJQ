using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "曾俊清";
            string clause = "爱学习，一天不学习就浑身难受！";
            Console.WriteLine(name + clause);
            //Console.ReadLine();
            //在“入栈口号”的基础上，
            //使用变量Age（年龄）、IsFemale（是否男生）、Height（身高，单位米）、FromCity（来自哪里）存储你的个人信息，
            //并在控制台逐行输出
            //输出两个整数 / 小数的和 / 差 / 积 / 商
            int Age = 22;
            bool IsFemale = false;
            double Height = 1.65;
            string FromCity = "江西";
            Console.WriteLine("年龄: " + Age + "\n是否男生：" + IsFemale + "\n身高：" + Height + "米" + "\n来自: " + FromCity);
           // Console.ReadLine();
            int i = 30 , j = 20;
            Console.WriteLine("\n整数");
            Console.WriteLine("和：" + (i+j)+ "\n差："+ (i-j)+ "\n积："+(i*j)+"\n商:"+(i/ (float)j));
            double m = 9.99, n = 1.11;
            Console.WriteLine("\n小数");
            Console.WriteLine("和：" + (m + n) + "\n差：" + (m - n) + "\n积：" + (m * n) + "\n商:" + (m / n));
            Console.ReadLine();
        }
    }
}
