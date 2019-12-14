using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class SomeFuntion
    {
        //实现方法：
        //IndexOf()，通过遍历在无序数组中
        //找到某个值的下标，找不到返回-1
        static void IndexOf(double[] arr, double num)
        {
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine("第" + (i + 1) + "位");
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    j++;
                    if (j == arr.Length)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        //nothing to do 
                    }
                }
            }
        }
        //构造一个能装任何数据的数组，并完成数据的读写
        public void GetArr()
        {
            object[] objarr = new object[5]; //{ 88, 95.5, "", "飞哥", 2019 / 11 / 29 };
            int arr1 = 88;
            objarr[0] = arr1;
            double arr2 = 95.5;
            objarr[1] = arr2;
            string arr3 = "飞哥";
            objarr[2] = arr3;
            DateTime arr4 = new DateTime(2019, 11, 29);
            objarr[3] = arr4;
            string arr5 = "";
            objarr[4] = arr5;
            Console.WriteLine(objarr[0]);
            Console.WriteLine(objarr[1]);
            Console.WriteLine(objarr[2]);
            Console.WriteLine(objarr[3]);
            Console.WriteLine(objarr[4]);
        }
    }


}

