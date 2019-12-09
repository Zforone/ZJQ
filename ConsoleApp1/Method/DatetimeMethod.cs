using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Method
{
    public class DatetimeMethod
    {
        //函数GetDate()，能计算一个日期若干（日/周/月）后的日期
        public void GetDate(DateTime inputDate)
        {
            for (int i = 0; i < 3; i++)
            {
                string dateTime = inputDate.ToString("yyyy年MM月dd日");
                DateTime beforeDate = inputDate;
                string input = Console.ReadLine();
                string inputStr = Regex.Replace(input, @"[^\d.\d]", "");
                Console.WriteLine("当前日期：" + dateTime + ",请输入：XX日/周/月,然后回车");
                int inputNum = int.Parse(inputStr);
                if (input == (inputStr + "日"))
                {
                    DateTime afterDate = beforeDate.AddDays(inputNum);
                    Console.WriteLine(input + "后的日期是：" + afterDate.ToString("yyyy年MM月dd日"));
                    break;
                }
                else if (input == (inputStr + "周"))
                {
                    DateTime afterDate = beforeDate.AddDays(inputNum * 7);
                    Console.WriteLine(input + "后的日期是：" + afterDate.ToString("yyyy年MM月dd日"));
                    break;
                }
                else if (input == (inputStr + "月"))
                {
                    DateTime afterDate = beforeDate.AddMonths(inputNum);
                    Console.WriteLine(input + "后的日期是：" + afterDate.ToString("yyyy年MM月dd日"));
                    break;
                }
                else
                {
                    Console.WriteLine("输入格式不正确");
                }
            }
        }
        //给定任意一个年份，就能按周排列显示每周的起始日期
        public void Date()
        {
            string input = Console.ReadLine();
            int a = 1;
            bool result = int.TryParse(input, out a);
            if (result)
            {
                int inputDate = int.Parse(input);
                DateTime date = new DateTime(inputDate, 1, 1);
                DateTime fristDay = date;
                while (date.DayOfWeek != DayOfWeek.Monday)
                {
                    date = date.AddDays(1);
                }
                DateTime fristDate = date;
                Console.WriteLine("第1周："
                    + fristDay.ToString("yyyy年MM月dd日")
                    + "---"
                    + fristDate.AddDays(-1).ToString("yyyy年MM月dd日"));
                DateTime last = new DateTime(inputDate, 12, 31);
                DateTime lastDay = last;
                while (last.DayOfWeek != DayOfWeek.Monday)
                {
                    last = last.AddDays(-1);
                }
                DateTime lastDate = last;

                int k = ((lastDate - fristDate).Days) / 7;
                for (int j = 2; j <= k + 1; j++)
                {
                    Console.WriteLine("第" + j + "周："
                        + fristDate.ToString("yyyy年MM月dd日")
                        + "---"
                        + fristDate.AddDays(6).ToString("yyyy年MM月dd日"));
                    if (date.Year == inputDate)
                    {
                        fristDate = fristDate.AddDays(7);
                    }
                }
                Console.WriteLine("最后1周："
                    + lastDate.ToString("yyyy年MM月dd日")
                    + "---"
                    + lastDay.ToString("yyyy年MM月dd日"));
            }
            else
            {
                Console.WriteLine("请输入一个数字");
            }
        }

    }
}
