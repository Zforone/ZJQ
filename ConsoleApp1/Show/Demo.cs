using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Funtion
{
    public class Demo
    {
    }
    //用代码证明struct定义的类型是值类型
    public struct Point
    {
        internal int i, j;
        internal Point(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
}
