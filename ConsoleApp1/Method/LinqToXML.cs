using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.Method
{
    public static class LinqToXML
    {
        public static void GetXML()
        {
            //生成一个XML对象
            XElement luckystack =
                new XElement("articles",
                new XComment(" 以下存放所有“源栈”所有文章！"),
                new XElement("article", new XAttribute("isDraft", false),
                new XElement("id", "1"),
                new XElement("title", "源栈培训：C#进阶-7：Linq to XML"),
                new XElement("body", "什么是XML（EXtensible Markup Language）是一种文本文件格式被设计用来传输和存储数据由：标签和属性组成元素（节点），由元素组成“树状结构”必须有而且只能有一个根节点其他："),
                new XElement("authorId", "1"),
                new XElement("publishDate", "2019/12/21 15:15"),
                new XElement("comments",
                    new XElement("comment",
                    new XAttribute("recommend", true),
                    new XElement("id", "12"),
                    new XElement("body", "不错，赞！"),
                    new XElement("authorId", "2")
                                ),
                    new XElement("comment",
                    new XElement("id", "14"),
                    new XElement("body", "作业太难了"),
                    new XElement("authorId", "3")
                                )
                            )
                           ),
                new XElement("article", new XAttribute("isDraft", true),
                    new XElement("id", "2"),
                    new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
                    new XElement("authorId", "1")
                    ));
            Console.WriteLine(luckystack);
            
            //以文件形式存放到磁盘中
            XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), luckystack);
            document.Save("E://XML.xml");

            Console.WriteLine();
            Console.WriteLine("-----分界线-----");
            Console.WriteLine();


            //在根节点下添加一个新的article元素，内容至少包含id、title和authorId 
            luckystack.Add(new XElement("article", new XAttribute("isDraft", true),
                            new XElement("id", "88"),
                            new XElement("title", "源栈"),
                            new XElement("authorId", "88")
                                        )
                            );
            luckystack.Save("E:\\17bang.xml");
            Console.WriteLine(luckystack);
            //删除id = 12的评论
            //改变id = 2的article：isDraft = false，title = 源栈培训：C#进阶-8：异步和并行



        }
    }
}
