using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Stack
    {
        //实现-个模拟栈，增加如下功能:
        //●出栈Pop(),弹出栈顶数据
        //●入栈Push()， Push可以--次性压入多个数据;
        //●出入栈检查,
        //。如果压入的数据已超过栈的深度(最大容量)，提示“栈溢出”
        //。如果已弹出所有数据，提示“栈已空”

        //使用object改造数据结构栈（Stack），并在出栈时获得出栈元素

        private string[] _arr;
        private int top;
        public Stack(int length)
        {
            //top = arr.Length-1;
            _arr = new string[length];

        }
        public Stack()
        {
        }
        public void Push(params string[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (top >= _arr.Length)
                {
                    Console.WriteLine("栈满！");
                }
                else
                {
                    _arr[top] = elements[top];
                    Console.WriteLine(_arr[top]);
                    top++;
                }
            }
        }
        public void Pop(params string[] elements)
        {
            _arr = (string[])elements.Clone();
            top = elements.Length - 1;
            for (int i = 0; i <= _arr.Length; i++)
            {
                if (_arr[0] == null)
                {
                    Console.WriteLine("栈空！");
                }
                else
                {
                    string temp = _arr[top];
                    _arr[top] = null;
                    Console.WriteLine(temp);
                }
                top--;
            }
        }
    }
    public class Function
    {
        //函数GetDate()，能计算一个日期若干（日/周/月）后的日期
        public void GetDate(DateTime inputDate)
        {
            for (int i = 0; i < 3; i++)
            {
                string dateTime = inputDate.ToString("yyyy年MM月dd日");
                DateTime beforeDate = inputDate;
                string input = Console.ReadLine();
                string inputStr = Regex.Replace(input, @"[^\d.\d]", "");
                Console.WriteLine("当前日期：" + dateTime + ",请输入：XX日/周/月,然后回车");
                int inputNum = int.Parse(inputStr);
                if (input == (inputStr + "日"))
                {
                    DateTime afterDate = beforeDate.AddDays(inputNum);
                    Console.WriteLine(input + "后的日期是：" + afterDate.ToString("yyyy年MM月dd日"));
                    break;
                }
                else if (input == (inputStr + "周"))
                {
                    DateTime afterDate = beforeDate.AddDays(inputNum * 7);
                    Console.WriteLine(input + "后的日期是：" + afterDate.ToString("yyyy年MM月dd日"));
                    break;
                }
                else if (input == (inputStr + "月"))
                {
                    DateTime afterDate = beforeDate.AddMonths(inputNum);
                    Console.WriteLine(input + "后的日期是：" + afterDate.ToString("yyyy年MM月dd日"));
                    break;
                }
                else
                {
                    Console.WriteLine("输入格式不正确");
                }
            } 
        }
        //给定任意一个年份，就能按周排列显示每周的起始日期
        public void Date()
        {
            string input = Console.ReadLine();
            int a = 1;
            bool result = int.TryParse(input, out a);
            if (result)
            {
                int inputDate = int.Parse(input);
                DateTime date = new DateTime(inputDate, 1, 1);
                DateTime fristDay = date;
                while (date.DayOfWeek != DayOfWeek.Monday)
                {
                    date = date.AddDays(1);
                }
                DateTime fristDate = date;
                Console.WriteLine("第1周："
                    + fristDay.ToString("yyyy年MM月dd日")
                    + "---"
                    + fristDate.AddDays(-1).ToString("yyyy年MM月dd日"));
                DateTime last = new DateTime(inputDate, 12, 31);
                DateTime lastDay = last;
                while (last.DayOfWeek != DayOfWeek.Monday)
                {
                    last = last.AddDays(-1);
                }
                DateTime lastDate = last;

                int k = ((lastDate - fristDate).Days) / 7;
                for (int j = 2; j <= k + 1; j++)
                {
                    Console.WriteLine("第" + j + "周："
                        + fristDate.ToString("yyyy年MM月dd日")
                        + "---"
                        + fristDate.AddDays(6).ToString("yyyy年MM月dd日"));
                    if (date.Year == inputDate)
                    {
                        fristDate = fristDate.AddDays(7);
                    }
                }
                Console.WriteLine("最后1周："
                    + lastDate.ToString("yyyy年MM月dd日")
                    + "---"
                    + lastDay.ToString("yyyy年MM月dd日"));
            }
            else
            {
                Console.WriteLine("请输入一个数字");
            }
        }

        //用代码证明struct定义的类型是值类型
        
        
    }
    public class Arr
    {
        //构造一个能装任何数据的数组，并完成数据的读写
        
        public void Getarr()
        {
            object[] objarr = new object[5]; //{ 88, 95.5, "", "飞哥", 2019 / 11 / 29 };
            int arr1 = 88;
            objarr[0]= arr1;
            double arr2 = 95.5;
            objarr[1] = arr2;
            string arr3 = "飞哥";
            objarr[2] = arr3;
            DateTime arr4 =new DateTime (2019 , 11 , 29);
            objarr[3] = arr4;
            string arr5 = "";
            objarr[4] = arr5;
            Console.WriteLine((int)objarr[0]);
            Console.WriteLine((double)objarr[1]);
            Console.WriteLine((string)objarr[2]);
            Console.WriteLine((DateTime)objarr[3]);
            Console.WriteLine((string)objarr[4]);
        }
    }
}

