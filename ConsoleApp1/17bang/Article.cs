using ConsoleApp1._17bang;
using System;
using System.Collections.Generic;
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

        //一篇文章可以有多个关键字，
        internal IList<Keyword> KeyWord { get; set; }

        //一篇文章可以有多个评论
        internal IList <Comment> Comments { get; set; }

        public override void Publish()
        {
            
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
        //public void changeTime(DateTime createTime, DateTime publishTime)
        //{
        //    FieldInfo createField = typeof(Content).GetField("_createTime");
        //    createField.SetValue(this, createTime);

        //    FieldInfo publishField = typeof(Content).GetField("_publishTime");
        //    publishField.SetValue(this, publishTime);
        //}
    }
}
