using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //实例化文章和意见建议，调用他们：
    //继承自父类Content的属性和方法
    //自己的属性和方法
    internal class Article : Content
    {
        //private static string thekind;
        //public Article(string akind) : base(thekind)
        //{

        //}

        public override void Publish()
        {
            Author.HelpMoney -= 1;
        }

        public override void Agree()
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Article点赞！");
        }

        public override void Disagree()
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
    }
}
