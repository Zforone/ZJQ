using ConsoleApp1._17bang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1._17bang
{
    //●求助版块，定义一个类Problem,包含字段:标题(Title) 、文(Body)、 悬赏(Reward)、 发布时间(Publish
    //DateTime)和作者(Author) ，和方法Publish()
    public class Problem : Content
    {
        //将之前User/Problem/HelpMoney类的字段封装成属性，
        //考虑求助的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：
        //Publish()：发布一篇求助，并将其保存到数据库
        //Load(int Id)：根据Id从数据库获取一条求助
        //Delete()：删除某个求助
        //repoistory：可用于在底层实现上述方法和数据库的连接操作等
        //problem.Reward不能为负数

        //private static string thekind;
        //public Problem(string pkind) : base(thekind)
        //{

        //}

        public int _Reward;
        public int Reward
        {
            get { return _Reward; }
            set
            {
                if (value < 0)
                {
                    //修改之前的属性验证：problem.Reward为负数时直接抛出“参数越界”异常
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Reward = value;
                }
            }
        }

        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写
        [MaxLength(10)]
        public IList<ProblemAndKeyword> keyWords { get; set; }

        //private Keyword[] _keyWord = new Keyword[10];
        public ProblemAndKeyword this[int index]
        {
            get { return keyWords[index]; }
            set { keyWords[index] = value; }
        }
        internal void Publish(int Id)
        {

        }
        internal static void Load(int Id)
        {

        }
        internal void Delete(int Id)
        {

        }
        internal static void repoistory()
        {

        }

        public override void Publish()
        {

        }

        public override void Commentary()
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Problem评论！");
        }


    }


    public class ProblemAndKeyword
    {
        public int ProblemId { get; set; }
        public Problem Problem { get; set; }

        public int KeywordId { get; set; }
        public Keyword Keyword { get; set; }
    }
}

