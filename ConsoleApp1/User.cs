using System;

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



    internal sealed class User : Entity, ISendMessage, IChat
    {
        void ISendMessage.Send()
        {
            Console.WriteLine("ISendMessage");
        }
        void IChat.Send()
        {
            Console.WriteLine("IChat");
        }

        internal string _name;
        internal string Name
        {
            get { return _name; }
            set
            {
                if (value == "Admin")
                {
                    value = "系统管理员";
                    _name = value;
                    // Console.WriteLine(_name );
                }
                else
                {
                    _name = value;

                }

            }

        }

        internal int userLevel;

        private int _password;
        private int Password { get; set; }

        internal User _invitedby;
        internal User InvitedBy { get; set; }
        public uint _HelpMoney = 100;
        public uint HelpMoney { get { return _HelpMoney; } set { _HelpMoney = value; } }
        public uint _HelpPoint = 100;
        public uint HelpPoint { get { return _HelpPoint; } set { _HelpPoint = value; } }
        public uint _HelpBeans = 100;
        public uint HelpBeans { get { return _HelpBeans; } set { _HelpBeans = value; } }

        internal void Register(string name, int password, User invitedby)
        {

        }

        internal void Login(string name, int password)
        {

        }

        private void ChangePasword(int oldPassWord, int newPassWord)
        {

        }
        //一起帮中用户可以被分为：
        //    访客（Visited）、注册用户（Registered）、可发布（Published）和管理员（Admin）。
        //    请据此设计一个枚举类型Role（角色），并将其用于User对象，让User对象可以角色属性
       public Role GetRole(int userLevel)
        {
            Role level = (Role)userLevel;
            return level;   
        }        
    }
    public enum Role
    {
        Admin=0,
        Registered=1,
        Visited=2,
        Publishe=3
    }

    


}
