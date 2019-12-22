using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Method
{
    public class Function
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


        //实现GetCount(string container, string target)方法，可以统计出container中有多少个target
        public static int GetCount(string container, string target)
        {
            int resulte = 0;
            int targetLength = target.Length;
            for (int i = 0; i < container.Length; i++)
            {
                if (container.Length - i >= targetLength)
                {
                    string character = container.Substring(i, targetLength);
                    if (target == character)
                    {
                        resulte++;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    break;
                }

            }
            return resulte;
        }


        //不使用string自带的Join()方法，定义一个mimicJoin()方法，
        //能将若干字符串用指定的分隔符连接起来，
        //比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d

        public static String mimicJoin(char separator, params string[] values)
        {
            string result=string.Empty;
            for (int i=0;i < values.Length; i++)
            {
                
                if (i == values.Length - 1)
                {
                    result += values[i];
                }
                else
                {
                    result = result + values[i] + separator;
                }

            }
            return result;
        }

    }
}

