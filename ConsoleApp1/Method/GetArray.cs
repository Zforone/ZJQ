using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    public class GetArrays
    {
        //定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
        //最小值（默认为1）
        //相邻两个元素之间的最大差值（默认为5）
        //元素个数（默认为10个）
        public static int[] GetArray(int min = 1, int i = 5, int j = 10)
        {
            int[] arr = new int[j];
            arr[0] = min;
            Console.Write(arr[0] + ",");
            for (int k = 1; k < arr.Length; k++)
            {
                Random num = new Random();
                int randomNum = num.Next(arr[k - 1], (arr[k - 1] + i));
                if (randomNum >= arr[k - 1])
                {
                    arr[k] = randomNum;
                    Console.Write(arr[k] + ",");
                }
                else
                {
                    k--;
                }
            }
            return arr;
        }
        //重载GetArray()，使其返回一个string[]
        public static string[] GetArray(string min = "1", string i = "5", string j = "10")
        {
            int a = 0;
            bool result = int.TryParse(min, out a) && int.TryParse(i, out a) && int.TryParse(j, out a);
            string[] arr1 = null;
            if (result)
            {
                int Min = int.Parse(min);
                int I = int.Parse(i);
                int J = int.Parse(j);
                int[] arr = new int[J];
                arr[0] = Min;
                arr1 = new string[J];
                arr1[0] = arr[0].ToString();
                Console.Write(arr[0] + ",");
                for (int k = 1; k < arr.Length; k++)
                {
                    Random num = new Random();
                    int randomNum = num.Next(arr[k - 1], (arr[k - 1] + I));
                    if (randomNum >= arr[k - 1])
                    {
                        arr[k] = randomNum;
                        arr1[k] = arr[k].ToString();
                        Console.Write(arr1[k] + ",");
                    }
                    else
                    {
                        k--;
                    }
                }
            }
            else
            {
                Console.WriteLine("参数输入错误！");
            }
            return arr1;
        }
    }
}
