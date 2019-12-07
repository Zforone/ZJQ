using System;
using System.Reflection;

namespace ConsoleApp1
{
    //实例化文章和意见建议，调用他们：
    //继承自父类Content的属性和方法
    //自己的属性和方法
    internal class Article : Content,IAgree 
    {
        //private static string thekind;
        //public Article(string akind) : base(thekind)
        //{

        //}
        public Article():base()
        {

        }

        public override void Publish()
        {
            _publishTime = new DateTime ();
            Author.HelpMoney -= 1;
        }

        public void Agree(User voter)
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Article点赞！");
        }

        public void Disagree(User voter)
        {
            Author.HelpPoint -= 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Article我踩！");
        }

        public override void Commentary()
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Article评论！");
        }
        //在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime
        public void changeTime(DateTime createTime, DateTime publishTime)
        {
            _createTime = createTime;
            _publishTime = publishTime;
        }
    }
}
