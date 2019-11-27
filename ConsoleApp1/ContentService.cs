using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //添加一个新类ContentService，其中有一个发布（Publish()）方法：

    //如果发布Article，需要消耗一个帮帮币
    //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
    //如果发布Suggest，不需要消耗帮帮币

    //一起帮里的求助总结、文章和意见建议，以及他们的评论，
    //都有一个点赞（Agree）/踩（Disagree）的功能，赞和踩和增减作者及评价者的帮帮点。
    //能不能对其进行抽象？如何实现

    internal class ContentService  
    { 
        public  void Publish(Content content )
        {
            content.Publish();
            Console.WriteLine("保存至数据库");
        }
        public void Agree(Content content)
        {
            content.Agree();
            Console.WriteLine("保存至数据库");
        }
        public void Disagree(Content content)
        {
            content.Disagree();
            Console.WriteLine("保存至数据库");
        }
        public void Commentary(Content content)
        {
            content.Commentary();
            Console.WriteLine("保存至数据库");
        }
    }
}
