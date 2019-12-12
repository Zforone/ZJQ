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

        }
        public Article Article { get; set; }
    }
}
