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

    internal abstract class Content :Entity<int> 
    {
        //protected Content(string thekind)
        //{
        //    kind = thekind;
        //}
        //protected string kind;

        public virtual void Publish()
        {
            //内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常
            if (Author == null)
            {
                throw new ArgumentNullException();
            }
            _publishTime = DateTime.Now;
        }
        public abstract void Commentary();

        //之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，
        //想一想他们应该在哪里赋值比较好，并完成相应代码
        protected DateTime _publishTime;
        public DateTime PublishTime { get { return _publishTime; } }
        protected DateTime _createTime;
        public DateTime CreateTime { get { return _createTime; } }
        public Content()
        {
            _createTime = DateTime.Now;
        }
        

        public User _Author;
        public User Author { get { return _Author; } set { _Author = value; } }
        
        public User _Executor ;//执行者
        public User Executor { get { return _Executor; } set { _Executor = value; } }
        
        public string Title { get; set; }
        
        public string Body { get; set; }

              
    }
}
