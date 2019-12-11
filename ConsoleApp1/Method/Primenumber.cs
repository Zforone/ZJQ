using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    class Primenumber
    {
        //找到100以内的所有质数（只能被1和它自己整除的数）
        public void PrimeNumber()
        {
            Console.WriteLine(1);
            Console.WriteLine(2);
            for (int n = 1; n < 100; n++)
            {
                for (int m = 2; m < n; m++)
                {
                    if (n % m == 0)
                    {
                        break;
                    }
                    else if (n - 1 == m)
                    {
                        Console.WriteLine(n);
                    }
                    else
                    {
                        //nothing
                    }
                }
            }
        }
    }
}
