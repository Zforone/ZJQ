using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1.LinqToXML
{
    public static class Operated
    {
        //现有一个txt文件，里面存放了若干email地址，
        //使用分号（;）或者换行进行了分隔。
        
       
        
        public static void FileOperated()
        {
            string path1 = "E:\\File\\File1.txt";
            string path2 = "E:\\File\\File2.txt";
            string path3 = "E:\\File\\File3.txt";
            //File.Create(path1);
            //File.Delete(path);
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i == 99)
            //    {
            //        File.AppendAllText(path1, $"email-{i }");
            //    }
            //    else
            //    {
            //        File.AppendAllText(path1, $"email-{i + 1};");
            //    }
            //}

            var collection = File.ReadLines(path1).SelectMany(a => a.Split(';')).Distinct();

            //请删除其中重复的email地址，
            //foreach (var item in collection)
            //{
            //    File.AppendAllText(path2, $"{item};");
            //}


            //并按每30个email一行（行内用;分隔）重新组织
            List<string> temp = new List<string>();
            File.Delete(path3);
            foreach (var item in collection)
            {
                temp?.Add($"{item};");
                if ((temp?.Count() % 30) == 1)
                {                    
                    File.AppendAllText(path3, $"\n{ item};");
                }
                else
                {
                    File.AppendAllText(path3, $"{ item};");
                }
            }
        }
    }
}
