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

        //声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出 
        public static int GetWater(ProvideWater provideWater )
        {
            Person person = new Person();
            //provideWater = new ProvideWater(UseDelegate);
            return provideWater(person);
        }

        public static void Transfer()
        {
            //使用方法给上述委托赋值，并运行该委托
            Person person1 = new Person();
            ProvideWater provideWater1 = new ProvideWater(UseDelegate);
            Console.WriteLine("used method");
            Console.WriteLine(provideWater1(person1));

            //使用匿名方法给上述委托赋值，并运行该委托
            ProvideWater provideWater2 = delegate (Person person)
             {
                 return 2;
             };
            Console.WriteLine("used anonymous method");
            Console.WriteLine(provideWater2(person1));

            //使用lambda表达式给上述委托赋值，并运行该委托
            ProvideWater provideWater3 = p => 3 ;
            Console.WriteLine("used lambda");
            Console.WriteLine(provideWater3(person1));

            //将ProvideWater的返回值输出
            ProvideWater provideWater4 = new ProvideWater(UseDelegate);
            Console.WriteLine("used GetWater() get a value");
            Console.WriteLine(GetWater(provideWater4));
        }
    }
}
