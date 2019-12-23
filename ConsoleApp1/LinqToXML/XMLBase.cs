using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.LinqToXML
{
    public static class XMLBase
    {
        public static void GetXML()
        {
            //生成一个XML对象
            XElement Articles =
                new XElement("articles",
                new XComment(" 以下存放所有“源栈”所有文章！"),
                new XElement("article",
                    new XAttribute("isDraft", false),
                new XElement("id", "1"),
                new XElement("authorName", "飞哥"),
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
                    new XElement("authorId", "3"))
                                )),

                new XElement("article", 
                    new XAttribute("isDraft", true),
                new XElement("id", "2"),
                new XElement("authorName", "小于"),
                new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
                new XElement("authorId", "2"),
                new XElement("publishDate", "2019/12/22 15:15"),

                new XElement("article",
                    new XAttribute("isDraft", true),
                new XElement("id", "3"),
                new XElement("authorName", "飞哥"),
                new XElement("title", "源栈培训：C#进阶-5：IO和文件"),
                new XElement("authorId", "1"),
                new XElement("publishDate", "2019/12/23 15:15"))
                            ));
            //Console.WriteLine(Articles);

            ////以文件形式存放到磁盘中
            //XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), Articles);
            //document.Save("E://XML.xml");

            //Console.WriteLine();
            //Console.WriteLine("-----分界线-----");
            //Console.WriteLine();


            ////在根节点下添加一个新的article元素，内容至少包含id、title和authorId 
            //Articles.Add(new XElement("article", new XAttribute("isDraft", true),
            //                new XElement("id", "88"),
            //                new XElement("title", "源栈"),
            //                new XElement("authorId", "88")
            //                            )
            //                );
            //Articles.Save("E:\\XMLadd.xml");
            //Console.WriteLine(Articles);


            //Console.WriteLine();
            //Console.WriteLine("-----分界线-----");
            //Console.WriteLine();


            ////删除id = 12的评论
            //XElement comment =
            //    (
            //    from c in Articles.Descendants("comment")
            //    where c.Element("id").Value == "12"
            //    select c
            //    ).Single();
            //comment.Remove();
            //Articles.Save("E:\\XMLremove.xml");
            //Console.WriteLine(Articles);

            //Console.WriteLine();
            //Console.WriteLine("-----分界线-----");
            //Console.WriteLine();

            ////改变id = 12的article：isDraft = false，title = 源栈培训：C#进阶-8：异步和并行
            //XElement updata =
            //    (
            //    from u in Articles.Descendants("article")
            //    where u.Element("id").Value == "2"
            //    select u
            //    ).Single();
            //updata.SetAttributeValue("isDraft", "false");
            //updata.SetElementValue("title", "源栈培训：C#进阶-8：异步和并行");
            //Articles.Save("E:\\XMLupdata.xml");
            //Console.WriteLine(Articles);

        }
    }
}
