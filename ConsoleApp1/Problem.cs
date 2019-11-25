using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //●求助版块，定义一个类Problem,包含字段:标题(Title) 、文(Body)、 悬赏(Reward)、 发布时间(Publish
    //DateTime)和作者(Author) ，和方法Publish()
    class Problem : Content
    {
        //将之前User/Problem/HelpMoney类的字段封装成属性，
        //考虑求助的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：
        //Publish()：发布一篇求助，并将其保存到数据库
        //Load(int Id)：根据Id从数据库获取一条求助
        //Delete()：删除某个求助
        //repoistory：可用于在底层实现上述方法和数据库的连接操作等
        //problem.Reward不能为负数

        private static string thekind;
        public Problem(string pkind):base (thekind )
        {

        }

        public string _keyword;
        public string keyWord { get; set; }

        internal void Publish(int Id)
        {

        }
        internal static void Load(int Id)
        {

        }
        internal void Delete(int Id)
        {

        }
        internal static void repoistory()
        {

        }
    }
}
