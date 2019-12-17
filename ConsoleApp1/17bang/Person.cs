using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._17bang
{
    public class Person
    {
        public int Age=18;
    }
    //声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型 
    public delegate int ProvideWater(Person person);


    public static class AboutDelegate
    {
        public static int UseDelegate(Person person)
        {   
            return 1;
        }
        public static void Add(int a,int b)
        {
            Console.WriteLine(a + b );
        }
        public static void Transfer()
        {
            //使用方法给上述委托赋值，并运行该委托
            Person person1 = new Person();
            ProvideWater provideWater1 = new ProvideWater(UseDelegate);
            Console.WriteLine("used method");
            Console.WriteLine(provideWater1(person1));

            //使用匿名方法给上述委托赋值，并运行该委托
            ProvideWater provideWater2 = delegate (Person person2)
             {
                 return 2;
             };
            Console.WriteLine("used anonymous method");
            Console.WriteLine(provideWater2(person1));

            //使用lambda表达式给上述委托赋值，并运行该委托
            ProvideWater provideWater3 = (p) => { return 3; };
            Console.WriteLine("used lambda");
            Console.WriteLine(provideWater3(person1));
        }
    }
}
