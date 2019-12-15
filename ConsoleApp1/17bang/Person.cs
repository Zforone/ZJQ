using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._17bang
{
    class Person
    {
    }
    //声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型 
    delegate int ProvideWater(Person person);
}
