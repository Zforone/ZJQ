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
    }
}
