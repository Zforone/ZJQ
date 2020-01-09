using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._17bang
{
    public class ArticleKind : Entity<int>
    {
        public string Name { get; set; }
        public IList<Article> Articles { get; set; }
    }
}
