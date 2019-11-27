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

        private string [] _arr;
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
        public void Pop(params string [] elements)
        {
            _arr = (string[])elements.Clone();
            top = elements.Length - 1;
            for (int i=0;i <=_arr .Length;i++)
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
                string dateTime = inputDate.ToString("yyyy年MM月dd日");
                DateTime beforeDate = inputDate;
                string input = Console.ReadLine();
                string inputStr = Regex.Replace(input, @"[^\d.\d]", "");

                int inputNum = int.Parse(inputStr);
                if (input == (inputStr + "日"))
                {
                    beforeDate = beforeDate.AddDays(inputNum);
                }
                else if (input == (inputStr + "周"))
                {
                    beforeDate = beforeDate.AddDays(inputNum * 7);
                }
                else if (input == (inputStr + "月"))
                {
                    beforeDate = beforeDate.AddMonths(inputNum);
                }
                else
                {
                    //
                }
                string afterDate = beforeDate.ToString("yyyy年MM月dd日");
                Console.WriteLine("当前日期：" + dateTime + ",请输入：XX日/周/月,然后回车");
                Console.WriteLine(input + "后的日期是：" + afterDate);
        }
    }    
}

