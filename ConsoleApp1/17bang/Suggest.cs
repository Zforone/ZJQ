using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._17bang
{
    //实例化文章和意见建议，调用他们：
    //继承自父类Content的属性和方法
    //自己的属性和方法

    public class Suggest : Content, IAppraise
    {
        //private static string thekind;
        //public Suggest(string skind):base(thekind )
        //{

        //}

        public override void Publish()
        {
            
        }
        
        public override void Commentary()
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Suggest评论！");
        }

        public void Agree(User voter)
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Suggest点赞！");
        }

        public void DisAgree(User voter)
        {
            Author.HelpPoint -= 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Suggest我踩！");
        }
    }
}
