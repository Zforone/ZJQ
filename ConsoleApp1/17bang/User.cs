using ConsoleApp1.AboutDB;
using ConsoleApp1.Method;
using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApp1._17bang
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



    public sealed class User : Entity<int>, ISendMessage, IChat
    {
        public User()
        {
            if (_dbHepler == null)
            {
                _dbHepler = new DBhepler();
            }
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

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "Admin")
                {
                    value = "系统管理员";
                    _name = value;

                }
                else if (TestName.TestOfName(value))
                {
                    Console.WriteLine("昵称不规范！");
                }
                else
                {
                    _name = value;

                }

            }
        }


        //将TokenManager作为User类的属性
        internal TokenManager TokenManager { get; set; }

        //一起帮中用户可以被分为：
        //    访客（Visited）、注册用户（Registered）、可发布（Published）和管理员（Admin）。
        //    请据此设计一个枚举类型Role（角色），并将其用于User对象，让User对象可以角色属性
        internal Role userLevel;


        //确保用户（User）的密码（Password）：
        //长度不低于6
        //必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成
        private string _passWord;
        public string Password
        {
            get { return _passWord; }
            set
            {
                if (value.Length >= 6 && TestPassWord.Result(value))
                {
                    _passWord = value;
                }
                else
                {
                    Console.WriteLine("password is too simple!");
                }
            }
        }


        public User InvitedBy { get; set; }

        public int HelpMoney { get; set; }
        public int HelpPoint { get; set; }
        public int HelpBeans { get; set; }

        private DBhepler _dbHepler;

        //将用户名和密码存入数据库：Register()
        internal void Register()
        {
            using (_dbHepler.Connection)
            {
                string sqlText = "INSERT Users (Name,Password) VALUES( @Name,@Password)";
                _dbHepler.ExecuteNonQuery(sqlText,
                      new SqlParameter[]
                      {
                            new SqlParameter("@Name", Name),
                            new SqlParameter("@Password", Password)
                      }
                      );
            }

        }

        //根据用户名和密码检查某用户能够成功登陆
        //如果用户成功登陆，将其最后登录时间（LatestLogonTime）改成当前时间
        public DateTime LatestLogonTime { get; private set; }
        internal bool Login()
        {
            LatestLogonTime = DateTime.Now;
            using (_dbHepler.Connection)
            {
                string sqlText =
                    @"SELECT * FROM Users WHERE [Name] = @Name AND [PassWord] = @Password";
                DbDataReader reader = _dbHepler.ExecuteReader(sqlText,
                      new SqlParameter[]
                      {
                            new SqlParameter("@Name", Name),
                            new SqlParameter("@Password", Password)
                      }
                      );
                string updateText =
                    $@"UPDATE Users SET LatestLogonTime='{DateTime.Now}' WHERE Name=@Name";
                _dbHepler.ExecuteNonQuery(updateText,
                    new SqlParameter[]
                      {
                            new SqlParameter("@Name", Name)
                      }
                    );
                return reader.Read();
            }

        }

        //查找出最近登录的若干个同学：IList<User> GetLatestLogon(int amount)
        public IList<User> GetLatestLogon(int amount)
        {
            string sqlText = $@"SELECT TOP({amount}) * FROM Users ORDER BY @LatestLogonTime DESC";
            DbDataReader reader = _dbHepler.ExecuteReader(sqlText,
                      new SqlParameter[]
                      {
                            new SqlParameter("@LatestLogonTime", LatestLogonTime),
                      }
                      );
            IList<User> users = new List<User>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < amount; i++)
                    {
                        users[i] = (User)reader[i];
                    }
                }
            }
            return users;
        }


        private void ChangePasword(int oldPassWord, int newPassWord)
        {

        }


    }
    public enum Role
    {
        Admin = 0,
        Registered = 1,
        Visited = 2,
        Publishe = 3
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
