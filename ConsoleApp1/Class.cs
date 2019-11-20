using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class
    {
        //观察“一起帮”的:
        //●注册登录功能，定义一个User类, 包含字段: Name(用户名)、Password(密码)和邀请人(InvitedBy) ,和方
        //法: Register()、 Login()
        //●求助版块，定义一个类Problem,包含字段:标题(Title) 、文(Body)、 悬赏(Reward)、 发布时间(Publish
        //DateTime)和作者(Author) ，和方法Publish()
        //●帮帮币版块，定义一个类HelpMoney,包含你认为应该包含的字段和方法
        //调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法
        //这些类的字段和方法设置合适的访问修饰符。
    }
    class User
    {
        internal User()
        {

        }
        internal User(string name)
        {
            
        }
            
        internal string Name;
        private DateTime Password;
        User InvitedBy;
        internal void Register(string name,DateTime password,User invitedby)
        {
            this.Name = name;
            this.Password = password;
            this.InvitedBy = invitedby;
        }
        internal void Login(string name,DateTime password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
    class Problem
    {
        internal Problem()
        {

        }
        internal Problem (string title)
        {

        }
        internal string Title;
        internal string Body;
        internal int Reward;
        DateTime PublishDateTime;
        internal string Author;
        internal void Publish()
        {
            
        }
    }
    class HelpMoney
    {
        internal HelpMoney()
        {

        }
        internal HelpMoney (int integrals)
        {

        }
        internal int bangbangcoins;
        internal int bangbangdots;
        internal int integrals;
        internal void changecoins(int changeNum)
        {
            bangbangcoins += changeNum;
        }
        internal void changedots(int changeNum)
        {
            bangbangdots += changeNum;
        }
        internal void change(int changeNum)
        {
            integrals += changeNum;
        }
    }
}
