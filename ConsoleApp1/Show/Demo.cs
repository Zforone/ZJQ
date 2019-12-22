using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Show
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
    //用代码演示泛型接口的协变/逆变 
    public interface IInterfaceA</*out*/in T>
    {

    }
    
    public class classA 
    {

    }
    public class classB : classA
    {

    }
    public class classC : IInterfaceA<classA>
    {

    }


}

