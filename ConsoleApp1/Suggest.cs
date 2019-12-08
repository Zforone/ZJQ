﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //实例化文章和意见建议，调用他们：
    //继承自父类Content的属性和方法
    //自己的属性和方法

    internal class Suggest : Content,IAgree 
    {
        private static string thekind;

        //public Suggest(string skind):base(thekind )
        //{

        //}
        public int Id { get; }

        public override void Publish()
        {
            //内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
            if (Author == null)
            {
                throw new ArgumentNullException();
            }
            _publishTime = new DateTime ();
            
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

        public void Disagree(User voter)
        {
            Author.HelpPoint -= 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Suggest我踩！");
        }
    }
}
