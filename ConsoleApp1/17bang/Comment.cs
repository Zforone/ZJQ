using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._17bang
{
    //评论（Comment）类
    class Comment
    {
        //一个评论必须有一个它所评论的文章
        public Comment(Article article)
        {
            Articles = article;
        }
        public Article Articles { get; set; }
        public string Contents { get; set; }
        //每个文章和评论都有一个评价 
        public void Agree()
        {

        }
        public void DisAgree()
        {

        }
    }
}
