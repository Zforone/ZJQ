using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    class StackMethod
    {
    }
    public class Stack
    {
        //实现-个模拟栈，增加如下功能:
        //●出栈Pop(),弹出栈顶数据
        //●入栈Push()， Push可以--次性压入多个数据;
        //●出入栈检查,
        //。如果压入的数据已超过栈的深度(最大容量)，提示“栈溢出”
        //。如果已弹出所有数据，提示“栈已空”

        //使用object改造数据结构栈（Stack），并在出栈时获得出栈元素

        public object[] _arr;
        public int top;
        public Stack(int length)
        {
            //top = arr.Length-1;
            _arr = new object[length];

        }
        public Stack()
        {
        }
        public void Push(params object[] elements)
        {
            top = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (top >= _arr.Length)
                {
                    Console.WriteLine("栈满！");
                }
                else
                {
                    _arr[top] = elements[top];
                    //Console.WriteLine(_arr[top]);
                    top++;
                }
            }
        }
        public void Pop(params object[] elements)
        {
            _arr = (object[])elements.Clone();
            top = elements.Length - 1;
            for (int i = 0; i <= _arr.Length; i++)
            {
                if (_arr[0] == null)
                {
                    Console.WriteLine("栈空！");
                }
                else
                {
                    object temp = _arr[top];
                    _arr[top] = null;
                    //Console.WriteLine(temp);
                }
                top--;
            }
        }
    }
}
