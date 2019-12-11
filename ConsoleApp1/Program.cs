using ConsoleApp1.Method;
using System;
using System.Reflection;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        
       
        static void Main(string[] args)

        {

            //User user = new User();
            //Problem problem = new Problem();
            ////problem.Reward = -10;
            ////problem.Author = new User();
            //Suggest suggest = new Suggest();
            ////Article article = new Article();
            ////Content content = new Article();

            ////在Main()函数调用ContentService时，捕获一切异常，并记录（）异常的消息和堆栈信息
            //try
            //{
            //    problem.Reward = -10;
            //    problem.Author = new User();
            //    new ContentService().Publish(/*article*/ /*suggest*/ problem);
            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.StackTrace + e.Message);                
            //}


            //problem.Reward = -1;
            //Console.WriteLine(problem.Reward);


            //用反射获取Publish()上的特性实例，输出其中包含的信息
            //ContentService contentService = new ContentService();
            //contentService.Publish(content);
            //Attribute attribute = Attribute.GetCustomAttribute(
            //    typeof(ContentService),             
            //    typeof(HelpMoneyChanged)      
            //);
            //object obj = attribute;
            //Console.WriteLine(((HelpMoneyChanged)obj));


            //DateTime dateTime = new DateTime(2019, 12, 05);
            //Console.WriteLine(article.PublishTime);
            //Console.WriteLine(article.CreateTime);
            //article.changeTime(dateTime, dateTime);
            //Console.WriteLine(article.PublishTime);
            //Console.WriteLine(article.CreateTime);

            //new ContentService().Agree(/*suggest,user*/article, user);
            //new ContentService().Disagree(suggest, user/*suggest,user*/);
            //new ContentService().Commentary(/*suggest*//*problem*/article);

            //user.userLevel = Role.Admin;


            //user.TokenManager = new TokenManager();
            //user.TokenManager.Add(Token.Admin);
            //user.TokenManager.Remove(Token.Admin);
            //Console.WriteLine(user.TokenManager.Has());


            double[] score = { 88.5, 95, 86, 99, 98 };
            GetMax getMax = new GetMax();
            Console.WriteLine(getMax.GetMaxInArray(score));
            Console.ReadLine();
        }
        ////将之前以下作业封装成方法（自行思考参数和返回值），并调用执行
        ////自我介绍：SelfIntroduce()
        //static void  SelfIntroduce(int age,bool isFemale,double height,string fromCity)
        //{
        //    Console.WriteLine("年龄: " + age  + "\n是否男生：" + isFemale + "\n身高：" + height + "米" + "\n来自: " + fromCity);
        //    Console.ReadLine();        
        //}
        ////加减乘除：Add() / Minus() / Mutiply() / Divide()
        //    static void Add(double fristnum,double secendnum)
        //{
        //    Console.WriteLine(fristnum + secendnum);
        //    Console.ReadLine(); 
        //}
        //static void Minus(double fristnum, double secendnum)
        //{
        //    Console.WriteLine(fristnum - secendnum);
        //    Console.ReadLine();
        //}
        //static void Mutiply(double fristnum, double secendnum)
        //{
        //    Console.WriteLine(fristnum * secendnum);
        //    Console.ReadLine();
        //}
        //static void Divide(double fristnum, double secendnum)
        //{
        //    Console.WriteLine(fristnum / secendnum);
        //    Console.ReadLine();
        //}

        ////取字符值：GetUnicode()
        //static void GetUnicode(char unicode)
        //{
        //    Console.WriteLine((int)unicode);
        //    Console.ReadLine();
        //}
        
        ////计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        //static void GetAverage(double [] score)
        //{
        //    int i;
        //    double j=0 ;
        //    for (i = 0; i <score .Length;i++)
        //    {  
        //        j += score[i]; 
        //    }
        //    Console.WriteLine(Math .Round ( j /score .Length,2)  );
        //    Console.ReadLine();
        //}
        
        //    //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
        //    double[] score = { 98, 78, 88.5, 86, 99, 75, 92.5, 75 };
        //    double maxScore;
        //    if (score[0] > score[1])
        //    {
        //        maxScore = score[0];
        //    }
        //    else
        //    {
        //        maxScore = score[1];
        //    }
        //    for (int i = 0; i < score.Length - 1;)
        //    {
        //        double j = score[i + 1];
        //        if (maxScore < j)
        //        {
        //            maxScore = j;
        //        }
        //        else
        //        {
        //            //nothing
        //        }
        //        i++;
        //    }
        //    Console.WriteLine(maxScore);

       

        //利用ref调用Swap()方法交换两个同学的床位号
        //static void Swap(ref int i, ref int j)
        //{
        //    int k = i;
        //    i = j;
        //    j = k;
        //}
        //使用tuple作为参数，重构SelfIntroduction()方法，输出自我介绍
        //static void SelfIntroduce((int age, bool isFemale, double height, string fromCity) SelfIntroduce)
        //{
        //    Console.WriteLine(SelfIntroduce.age);
        //    Console.WriteLine(SelfIntroduce.isFemale);
        //    Console.WriteLine(SelfIntroduce.height);
        //    Console.WriteLine(SelfIntroduce.fromCity);
        //}

    }
}
