using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
    //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
    //确保每个Content对象都有kind的非空值
    //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
    //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现
    class Content :Entity 
    {
        protected string kind;

        public DateTime _PublishDateTime;
        public DateTime PublishDateTime { get;private set; }

        private DateTime createTime;

        public string _Author;
        public string Author { get; set; }

        public string _Title;
        public string Title { get; set; }

        public string _Body;
        public string Body { get; set; }

        private string _Keyword;
        private string keyWord { get; set; }

        public int _Reward;
        public int Reward
        {
            get { return _Reward; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("奖赏不能少于零！");
                }
                else
                {
                    _Reward = value;
                }
            }
        }
    }
}
