using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._17bang
{
    //评论（Comment）类
    public class Comment : Entity<int> , IAppraise
    {
        //一个评论必须有一个它所评论的文章
        //public Comment(Article article)
        //{
        //    Articles = article;
        //}
        //public Article Articles { get; set; }
        //public string Contents { get; set; }

        public User _Author = new User();
        public User Author { get { return _Author; } set { _Author = value; } }

        public User _Executor = new User();//执行者
        public User Executor { get { return _Executor; } set { _Executor = value; } }
        //每个文章和评论都有一个评价
        public void Agree(User voter)
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("点赞！");
        }

        public void DisAgree(User voter)
        {
            Author.HelpPoint -= 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("我踩！");
        }
         
        
    }
}
