using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    //观察“一起帮”的:
    //●注册登录功能，定义一个User类, 包含字段: Name(用户名)、Password(密码)和邀请人(InvitedBy) ,和方
    //法: Register()、 Login()
    //调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法
    //这些类的字段和方法设置合适的访问修饰符。

    //将之前User/Problem/HelpMoney类的字段封装成属性，其中：
    //user.Password在类的外部只能读不能改，且为User类添加ChangePasword()方法，以修改其密码
    //如果user.Name为“admin”，输入时修改为“系统管理员”

    //让User类无法被继承



    internal sealed class User : Entity<int>, ISendMessage, IChat
    {
        static User()
        {
            User user = new User();
            user.BedWords = new List<string> { };
        }
        void ISendMessage.Send()
        {
            Console.WriteLine("ISendMessage");
        }
        void IChat.Send()
        {
            Console.WriteLine("IChat");
        }

        //设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词
        internal IList<string> BedWords { get; set; }
        private string _name;
        internal string Name
        {
            get { return _name; }
            set
            {
                if (value == "Admin")
                {
                    value = "系统管理员";
                    _name = value;

                }
                else if (SeekWord(value))
                {
                    Console.WriteLine("昵称不规范！");
                }
                else
                {
                    _name = value;

                }

            }
        }
        private bool resutle;
        private bool SeekWord(string word)
        {
            for (int i = 0; i < BedWords.Count; i++)
            {
                if (word.Contains(BedWords[i]))
                {
                    resutle = true;
                    break;
                }
                else
                {
                    continue;
                }

            }
            return resutle;
        }

        //将TokenManager作为User类的属性
        internal TokenManager TokenManager { get; set; }

        //一起帮中用户可以被分为：
        //    访客（Visited）、注册用户（Registered）、可发布（Published）和管理员（Admin）。
        //    请据此设计一个枚举类型Role（角色），并将其用于User对象，让User对象可以角色属性
        internal Role userLevel;

        private int Password { get; set; }

        internal User InvitedBy { get; set; }

        public int HelpMoney { get ; set ; }
        public int HelpPoint { get; set; }
        public int HelpBeans { get; set; }

        internal void Register(string name, int password, User invitedby)
        {

        }

        internal void Login(string name, int password)
        {

        }

        private void ChangePasword(int oldPassWord, int newPassWord)
        {

        }              
    }
    public enum Role
    {
        Admin=0,
        Registered=1,
        Visited=2,
        Publishe=3
    }

    //声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered
    [Flags]
    public enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16
    }
}
