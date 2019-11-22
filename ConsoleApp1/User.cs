using System;
using System.Collections.Generic;
using System.Text;

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



    sealed class User :Entity 
    {
        //internal User(string name)
        //{
            
        //}
        internal string _name; 
        internal string Name
        {
            get { return _name ; }
            set
            {if (value  == "admin")
                {
                    value  = "系统管理员";
                    _name = value;
                   // Console.WriteLine(_name );
                }
                else
                {
                    _name  = value;
                    
                }
                
            }
            
        }
        private int _password;
        private int Password { get; set; }

        internal User _invitedby;
        internal User InvitedBy { get; set; }

        internal void Register(string name,int password,User invitedby)
        {
            
        }

        internal void Login(string name,int password)
        {
            
        }

        private void ChangePasword(int oldPassWord,int newPassWord)
        {
            
        }
    }
}
