using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    public class PrimeNumber
    {
        //找到100以内的所有质数（只能被1和它自己整除的数）
        public List<int> PrimeList;
        public PrimeNumber()
        {
            PrimeList = new List<int>();
            PrimeList.Add(1);
            PrimeList.Add(2);
        }
        public void SeekPrimeNumber()
        {
            
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
                        //Console.WriteLine(n);
                        PrimeList.Add(n);
                        
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
