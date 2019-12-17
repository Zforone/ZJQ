
using ConsoleApp1.Method;
using System;
using System.Reflection;
using ConsoleApp1;
using static ConsoleApp1.Article;
using ConsoleApp1._17bang;
using System.Collections.Generic;
using System.Linq;

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
            //Article article = new Article();
            //article.Publish();
            //Content content = new Article();
            //DateTime dateTime = new DateTime(2019, 12, 1);
            //article.Alter(content, dateTime,content.timeType);
            //User user = new User() {Password="Qq@777" };
            //TestName.BedWords = new List<string> { "17bang" , "admin" , "管理员" };
            //user.Name = "1ggg";


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
            //DoubleLink<int> DoubleLinkValues = new DoubleLink<int>(1);
            //DoubleLinkValues.Next = new DoubleLink<int>(2);
            //DoubleLinkValues.Next.Next = new DoubleLink<int>(3);
            ////new DoubleLink<int>(2).InsertAfter(DoubleLinkValues).;
            ////new DoubleLink<int>(3).InsertAfter(DoubleLinkValues);
            ////new DoubleLink<int>(4).InsertAfter(DoubleLinkValues);
            ////new DoubleLink<int>(5).InsertAfter(DoubleLinkValues);

            //foreach (var item in DoubleLinkValues)
            //{
            //    Console.WriteLine(item);
            //}

            //problem.Reward = -1;
            //Console.WriteLine(problem.Reward); 




            //new ContentService().Agree(/*suggest,user*/article, user);
            //new ContentService().Disagree(suggest, user/*suggest,user*/);
            //new ContentService().Commentary(/*suggest*//*problem*/article);

            //user.userLevel = Role.Admin;


            //user.TokenManager = new TokenManager();
            //user.TokenManager.Add(Token.Admin);
            //user.TokenManager.Remove(Token.Admin);
            //Console.WriteLine(user.TokenManager.Has());


            //IInterfaceA<classB> interfaceA = new classC();
            //IInterfaceA<classA> interfaceB = interfaceA;

            //IInterfaceA<classA> interfaceA = new classC();
            //IInterfaceA<classB> interfaceB = interfaceA;

            //string resulte = Function.mimicJoin('*', "1", "2", "5", "8", "*");
            //Console.WriteLine(resulte);

            AboutDelegate.Transfer();

            Console.ReadLine();
        }
        
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
