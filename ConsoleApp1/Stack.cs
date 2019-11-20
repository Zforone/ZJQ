using System;
using System.Collections.Generic;
using System.Text;

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

        public int[] arr = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        public void Pop(int i)
        {
            if (i < arr.Length)
            {
                Console.WriteLine(arr[i]);
            }
            else
            {
                //
            }
            if (i == arr.Length)
            {
                Console.WriteLine("栈溢出");
            }
            else if (i == 0)
            {
                Console.WriteLine("栈已空");                
            }
            else
            {
                //
            }
        }
        public void Push(int j)
        {            
            if (j == arr.Length)
            {
                Console.WriteLine("栈溢出");
                
            }
            else if (j == 0)
            {
                Console.WriteLine("栈已空");
            }
            else
            {
                //
            }
            if (j < arr.Length)
            {
                Console.WriteLine(arr[j]);
            }
            else
            {
                //
            }
        }
        public void stack(bool a= true)
        {
            for (int k = arr.Length; k > -arr.Length-1; k--)
            {
                bool n = (k > 0);
                if (n)
                {
                    int i = k;
                    Pop(i);
                }               
                else if (k == 0)
                {
                    Pop(k);
                    Push(k);
                }
                else if (!a)
                {
                    int j = -k;
                    Push(j);                   
                    Push(j);
                    k -= 1;                   
                }
                else  
                {
                    int j = -k;
                    Push(j);                     
                }
            }
        }
    }
}
