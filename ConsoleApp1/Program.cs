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



            //Arr arr = new Arr();
            //arr.GetArr();

            //Point p1 = new Point(30,20);
            //Point p2 = p1;
            //p1.i = 10;
            //Console.WriteLine(p2.i);  //因为struct是值类型输出30，

            //DateTime time = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
            //new Function().GetDate(time);
            //new Function().Date();
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
            //    string[] studentName = { "王新", "陈百万", "阿泰" };
            //    Console.WriteLine(studentName.Length);
            //    Console.WriteLine(studentName[0] + "," + studentName[1] + "," + studentName[2]);
            //    string[,] studentNumber = {
            //        { "于维谦", "彭志强", "陈百万" },
            //        { "赵敬春", "王新", "刘江平" } ,
            //        { "幸龙泰", "曾俊清", "杨进文" }
            //    };
            //    Console.WriteLine(studentNumber.Length);
            //    Console.WriteLine(studentNumber[2, 1]);


            //    //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //    for (int forNum = 1; forNum < 6;)
            //    {
            //        Console.WriteLine(forNum);
            //        forNum++;
            //    }
            //    int whileNum = 1;
            //    while (whileNum < 10)
            //    {
            //        Console.WriteLine(whileNum);
            //        whileNum += 2;
            //    }
            //    //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //    for (int for1d = 0; for1d < studentName.Length;)
            //    {
            //        Console.WriteLine(studentName[for1d]);
            //        for1d++;
            //    }
            //    int rowLength = studentNumber.GetLength(0);
            //    int colunmLength = studentNumber.GetLength(1);
            //    for (int for2DRow = 0; for2DRow < rowLength;)
            //    {
            //        for (int for2DColunm = 0; for2DColunm < colunmLength;)
            //        {
            //            Console.Write(studentNumber[for2DRow, for2DColunm]);
            //            for2DColunm++;
            //        }
            //        for2DRow++;
            //        Console.WriteLine();
            //    }

            //    //让电脑计算并输出：99 + 97 + 95 + 93 +...+ 1的值
            //    int sun = 0;
            //    for (int sunNum = 99; sunNum > 0;)
            //    {

            //        //Console.WriteLine(sunNum );
            //        sun += sunNum;
            //        sunNum -= 2;
            //    }
            //    Console.WriteLine(sun);

            //Add(1, 1);
            //Minus(2, 1);
            //Mutiply(2, 2);
            //Divide(8, 2);
            //SelfIntroduce(18, true, 1.80, "江西");
            //GetUnicode('帅');
            //GetMax(new double[] { 58, 48, 59.5, 59 });
            //GetAverage(new double[] { 80, 80, 80 });
            //GuessMe();
            //int frist = 1;
            //int secend = 2;
            //Swap(ref frist, ref secend);
            //Console.WriteLine("交换：" + frist + " ," + secend);
            //int[] a = GetArray(100, 100, 10);
            //string[] b = GetArray("100", "100", " 10");

            //double[] arr = { 99, 111, 222, 333, 400, 400, 555 };
            //Random num = new Random();
            //int randomNum = num.Next(0, 6);
            //double i = arr[randomNum];
            //BinarySeek.BinaryOfSeek<int>(arr, i, arr.Length);

            //Console.WriteLine("输入的数字：" + i );
            //int age = 8;
            //bool isFemale = true;
            //double height = 55.22;
            //string fromCity = "jjj";
            //SelfIntroduce((age, isFemale, height, fromCity));
            //SelfIntroduce(SelfIntroduce: (age, isFemale, height, fromCity));
            //IndexOf(arr, 333);
            //Console.WriteLine( a );
            //Console.WriteLine("数组："+ arr); 
            //User i = new User();
            //User j = new User(""); 
            //Stack put = new Stack(3);
            //put.Push("A", "B", "C");
            //put.Pop("A", "B", "C");

            //new Problem().Reward = -5;
            //new User().Name = "admin";
            //Console.WriteLine();

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
        ////取最高分：GetMax()
        //static void GetMax(double [] score)
        //{
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
        //完成“猜数字”游戏，方法名GuessMe()
        /*完成猜数字的游戏：
        *弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
        *浏览器生成一个不大于1000的随机正整数；
        *用户输入猜测；
        *只用了不到6次就猜到，弹出：碉堡了！
        *只用了不到8次就猜到，弹出：666！
        *用了8-10次猜到，弹出：猜到了。
        *用了10次都还没猜对，弹出：^(*￣(oo)￣)^  */
        //static void GuessMe()
        //{
        //    Random num = new Random();
        //    int randomNum = num.Next(1000);  /*666*/
        //    for (int i = 0; i < 10; i++) 
        //    {
        //        Console.WriteLine("第" + (i + 1) + "次," + "请输入一个整数：");
        //        string input = Console.ReadLine();
        //        int a = 0;
        //        bool result = int.TryParse(input, out a);
        //        if (result == true)
        //        {
        //            int inputNum = int.Parse(input);
        //            if (inputNum > randomNum)
        //            {
        //                Console.WriteLine("大了！");
        //                if (i >= 9)
        //                {
        //                    Console.WriteLine("^(*￣(oo)￣)^ ！");
        //                    break;
        //                }
        //                else
        //                {
        //                    continue;
        //                }
        //            }
        //            else if (inputNum < randomNum)
        //            {
        //                Console.WriteLine("小了！");
        //                if (i >= 9)
        //                {
        //                    Console.WriteLine("^(*￣(oo)￣)^ ！");
        //                    break;
        //                }
        //                else
        //                {
        //                    continue;
        //                }
        //            }
        //            else if (inputNum == randomNum)
        //            {
        //                if (i < 5)
        //                {
        //                    Console.WriteLine("碉堡了！");
        //                }
        //                else if (i < 7)
        //                {
        //                    Console.WriteLine("666！");
        //                }
        //                else if (i <= 9)
        //                {
        //                    Console.WriteLine("猜到了！");
        //                }
        //                else
        //                {
        //                    //nothing to do                        
        //                }
        //                break;
        //            }
        //            else
        //            {
        //                //nothing to do  
        //            }
        //        }
        //        else if (i < 9)
        //        {
        //            Console.WriteLine("请输入一个数字！");
        //        }
        //        else
        //        {
        //            if (i >= 9)
        //            {
        //                Console.WriteLine("^(*￣(oo)￣)^ ！");
        //                break;
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //    }
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

        //    //找到100以内的所有质数（只能被1和它自己整除的数）

        //    Console.WriteLine(1);
        //    Console.WriteLine(2);
        //    for (int n = 1; n < 100; n++)
        //    { 
        //        for (int m = 2; m < n; m++)
        //        {
        //            if (n % m == 0)
        //            {
        //                break;
        //            }
        //            else if (n - 1 == m)
        //            {
        //                Console.WriteLine(n);
        //            }
        //            else
        //            {
        //                //nothing
        //            }  
        //        }  
        //    }

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
