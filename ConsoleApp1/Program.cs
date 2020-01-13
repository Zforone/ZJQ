
using ConsoleApp1.Method;
using System;
using System.Reflection;
using ConsoleApp1;
using ConsoleApp1._17bang;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using ConsoleApp1.LinqToXML;
using ConsoleApp1.AboutDB;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ConsoleApp1.Repoistories;

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
            //User user = new User() { Password = "Qq@777" };
            //user.Name = "17anggg";


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

            //string resulte = Function.mimicJoin('*', "1", "2", "5", "8", "*");
            //Console.WriteLine(resulte);

            //AboutDelegate.Transfer();

            //UsedLinq.Do();

            //再从磁盘中读取到内存中
            //XElement element = XElement.Load("E://XML.xml");
            //Console.WriteLine(element);

            //Operated.FileOperated();

            //XMLBase.GetXML();
            //XMLAdvanced.UserData();

            //new Student { Id=6, Name = "飞哥", Age = 28 }.Save();
            //new Student { Id=7, Name = "小于", Age = 18 }.Save();
            //new Student {Id=2 }.Delete();

            //将用户名和密码存入数据库：Register()
            //new User { Name = "优秀", Password ="Qq123/"}.Save();
            //new User { Name = "阿泰",Password="Aa123/"}.Save();

            User user = new User { Name = "百万", Password = "AZz12/" };
            //user.Register();
            //user.Login();
            User user1 = new User { Name = "阿泰", Password = "Aa123/" };
            //user1.Register();
            //user1.Login();
            User user2 = new User();
            user2.Name = "优秀";
            user2.Password = "Qq123/";
            //user2.Register();
            //user2.Login();


            IList<User> users = user1.GetLatestLogon(2);
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(users[i].Name);
            }

            //Repoistory<HelpMoney> helpMoney = new HelpMoneyRepository();
            //DatabaseFacade database = new Repoistory<HelpMoney>().Database;
            //DatabaseFacade database = new Repoistory<ArticleKind>().Database;
            //database.EnsureDeleted();                              
            //database.EnsureCreated();



            Console.WriteLine("!O^O!");
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
