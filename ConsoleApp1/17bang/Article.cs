using ConsoleApp1._17bang;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp1._17bang
{
    //实例化文章和意见建议，调用他们：
    //继承自父类Content的属性和方法
    //自己的属性和方法
    internal class Article : Content,IAgree 
    {
        //private static string thekind;
        //public Article(string akind) : base(thekind)
        //{

        //}
        public Article():base()
        {

        }

        //一篇文章可以有多个关键字，
        internal IList<Keyword> KeyWords { get; set; }

        //一篇文章可以有多个评论
        internal IList <Comment> Comments { get; set; }



        private Keyword[] _keyWord = new Keyword[10];
        //public Keyword[] keyWord { get { return _keyWord; } set { _keyWord = value; } } 
        public Keyword this[int index]
        {
            get { return _keyWord[index]; }
            set { _keyWord[index] = value; }
        } 

        public void Agree(User voter)
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Article点赞！");
        }

        public void Disagree(User voter)
        {
            Author.HelpPoint -= 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Article我踩！");
        }

        public override void Commentary()
        {
            Author.HelpPoint += 1;
            Executor.HelpPoint += 1;
            Console.WriteLine("Article评论！");
        }
        public void Alter(Content content, DateTime dateTime, TimeType timeType)
        {
            //在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime
            Type type = typeof(Content);
            FieldInfo fieldInfo;
            fieldInfo = type.GetField(timeType.ToString(), BindingFlags.NonPublic | BindingFlags.Instance);
            fieldInfo.SetValue(timeType, dateTime);

        }

        public enum TimeType
        {
            _publishTime,
            _createTime
        }

    }
}
