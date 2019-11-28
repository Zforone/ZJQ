using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Commentary : IAgree
    {
        public User _Author = new User();
        public User Author { get { return _Author; } set { _Author = value; } }

        public User _Executor = new User();//执行者
        public User Executor { get { return _Executor; } set { _Executor = value; } }

        public void Agree(User voter)
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("点赞！");

        }

        public void Disagree(User voter)
        {
            Author.HelpPoint -= 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("我踩！");
        }
    }
}
