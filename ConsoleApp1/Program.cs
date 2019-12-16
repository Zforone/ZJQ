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
            User user = new User();
            user.BedWords = new List<string> { "17bang" };
            user.Name = "17banggg";

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

            
            Keyword sql = new Keyword() {KeywordName="SQL" };
            Keyword js = new Keyword() { KeywordName = "JS" };
            Keyword html = new Keyword() { KeywordName = "html" };
            Keyword css = new Keyword() { KeywordName = "css" };
            Keyword csharp = new Keyword() { KeywordName = "C#" };
            Keyword net = new Keyword() { KeywordName = ".NET" };
            

            Article article1 = new Article()
            { Author = new User() {Name="飞哥" },
                Title ="飞哥真帅",
                KeyWords =new List<Keyword> { sql, css ,csharp} };
            new ContentService().Publish(article1);

            Article article2 = new Article()
            { Author = new User() { Name = "小于" },
                Title = "源栈之花",
                KeyWords = new List<Keyword> { js } };
            new ContentService().Publish(article2);

            Article article3 = new Article()
            { Author = new User() { Name = "阿泰" },
                Title = "沙区扛把子",
                KeyWords = new List<Keyword> { net, html } };
            new ContentService().Publish(article3);

            Comment comment1 = new Comment(article1) { Contents = "帅" };
            Comment comment2 = new Comment(article1) { Contents = "真帅" };
            Comment comment3 = new Comment(article1) { Contents = "非常帅" };
            Comment comment4 = new Comment(article2) { Contents = "源栈之花啊" };
            Comment comment5 = new Comment(article3) { Contents = "大佬" };

            article1.Comments = new List<Comment> {comment1,comment2,comment3 };
            article2.Comments = new List<Comment> { comment4 };
            article3.Comments = new List<Comment> { comment5 };

            IEnumerable<Article> articles = new List<Article> { article1, article2, article3 };

            //找出“飞哥”发布的文章
            var fgPaper = from a in articles
                        where a.Author.Name == "飞哥"
                        select a;
            foreach (var item in fgPaper)
            {
                Console.WriteLine(item.Title);
            }
            //找出2019年1月1日以后“小鱼”发布的文章
            var xyPpaper = from a in articles
                           where a.Author.Name == "小于" && a.PublishTime > new DateTime(2019, 1, 1)
                           select a;
            foreach (var item in xyPpaper)
            {
                Console.WriteLine(item.Title);
            }
            //按发布时间升序 / 降序排列显示文章
            var time = from a in articles
                        orderby a.PublishTime ascending //升序
                       //orderby a.PublishTime descending  //降序
                       select a;
            foreach (var item in time)
            {
                Console.WriteLine(item.Title);
            }
            //统计每个用户各发布了多少篇文章
            var articlesNum = from u in articles   
                              group u by u.Author into um
                              select new
                              {
                                  name = um.Key.Name,
                                  num = um.Count()
                              };
            foreach (var item in articlesNum)
            {
                Console.WriteLine(item.name + ":"+item.num);
            }
            //找出包含关键字“C#”或“.NET”的文章
            var papers = from a in articles
                         where a.KeyWords.Contains(csharp) || a.KeyWords.Contains(net)
                         select a;
            foreach (var item in papers)
            {
                Console.WriteLine(item.Title);
            }
            //找出评论数量最多的文章
            var max = from a in articles
                      orderby a.Comments.Count() descending
                      select a;
            Console.WriteLine(max.ToList().First().Title);

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
