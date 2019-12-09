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

    //在ContentService中捕获异常
    //如果是参数为空异常，Console.WriteLine() 输出：
    //    内容的作者不能为空，将当前异常封装进新异常的InnerException，再将新异常抛出
    //如果是参数越界异常，Console.WriteLine() 输出：
    //    求助的Reward为负数（-XX），不再抛出异常
    internal class ContentService 
    {
        
        //将HelpMoneyChanged应用于Publish()方法
        [HelpMoneyChanged(99)]
        public  void Publish(Content content )
        {
            try
            {
                content.Publish();
                Console.WriteLine("保存至数据库");

            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("内容的作者不能为空");
                throw ane.InnerException;
            }
            catch (ArgumentOutOfRangeException )
            {
                Console.WriteLine("求助的Reward为负数（-XX）");                
            }
            finally
            {
                //ContentService中无论是否捕获异常，均要Console.WriteLine()输出：
                //    XXXX年XX月XX日 XX点XX分XX秒（当前时间），请求发布内容（Id = XXX）
                Console.WriteLine(DateTime.Now + "请求发布内容（Id=XXX）");
            }
            
        }
        public void Agree(IAgree content,User user)
        {
            content.Agree(user);
            Console.WriteLine("保存至数据库");
        }
        public void Disagree(IAgree content, User user)
        {
            content.Disagree(user);
            Console.WriteLine("保存至数据库");
        }
        public void Commentary(Content content)
        {
            content.Commentary();
            Console.WriteLine("保存至数据库");
        }
    }
}
