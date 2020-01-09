using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._17bang
{
    //关键字（Keyword）类
    public class Keyword : Entity<int>
    {
        public string KeywordName { get; set; }
        public int Used { get; set; }
        public Keyword UpperLevel { get; set; }
        //一个关键字可以对应多篇文章
        public IList<ArticleAndKeyword> Articles { get; set; }

        public IList<ProblemAndKeyword> Problems { get; set; }
    }
}
