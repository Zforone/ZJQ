using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    public class BinarySeek
    {
        //实现二分查找，方法名BinarySeek()
        public int SeekedNumIndex;
        public int BinaryOfSeek(int[] arr, int num, int j, int i = 0)//传入数组，查找的数字，     
        {
            int k;
            k = (i + j) / 2;
            if (arr[0] > arr[arr.Length - 1])
            {
                
                if (arr[k] == num)
                {
                    //Console.WriteLine("找出的数字：" + arr[k] + ",第" + (k + 1) + "个数字。");
                    SeekedNumIndex = k + 1;
                }
                else if (arr[k] < num)
                {
                    BinaryOfSeek(arr, num, k, i);
                }
                else
                {
                    BinaryOfSeek(arr, num, k, j);
                }
                
            }
            else
            {
                if (arr[k] == num)
                {
                    //Console.WriteLine("找出的数字：" + arr[k] + ",第" + (k + 1) + "个数字。");
                    SeekedNumIndex = k + 1;
                }
                else if (arr[k] < num)
                {
                    BinaryOfSeek(arr, num, k, j);
                }
                else
                {
                    BinaryOfSeek(arr, num, k, i);
                }
                
            }
            return SeekedNumIndex;
        }
    }
}
