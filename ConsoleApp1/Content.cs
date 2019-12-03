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

    //思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。

    internal abstract class Content :Entity 
    {
        //protected Content(string thekind)
        //{
        //    kind = thekind;
        //}
        //protected string kind;

        public abstract void Publish();
        public abstract void Commentary();
       
        public DateTime PublishDateTime { get;private set; }

        private DateTime createTime;

        public User _Author=new User ();
        public User Author { get { return _Author; } set { _Author = value; } }
        
        public User _Executor = new User();//执行者
        public User Executor { get { return _Executor; } set { _Executor = value; } }
        
        public string Title { get; set; }
        
        public string Body { get; set; }
        
        private string keyWord { get; set; }       
    }
}
