using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    class NumberGame
    {
        //完成“猜数字”游戏，方法名GuessMe()
        /*完成猜数字的游戏：
        *弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
        *浏览器生成一个不大于1000的随机正整数；
        *用户输入猜测；
        *只用了不到6次就猜到，弹出：碉堡了！
        *只用了不到8次就猜到，弹出：666！
        *用了8-10次猜到，弹出：猜到了。
        *用了10次都还没猜对，弹出：^(*￣(oo)￣)^  */
        static void GuessMe(int inputNum)
        {
            Random num = new Random();
            int randomNum = num.Next(1000);  /*666*/
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine("第" + (i + 1) + "次," + "请输入一个整数：");
                //string input = Console.ReadLine();
                //int a = 0;
                //bool result = int.TryParse(input, out a);
                //if (result == true)
                //{
                //    int inputNum = int.Parse(input);
                    if (inputNum > randomNum)
                    {
                        Console.WriteLine("大了！");
                        if (i >= 9)
                        {
                            Console.WriteLine("^(*￣(oo)￣)^ ！");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (inputNum < randomNum)
                    {
                        Console.WriteLine("小了！");
                        if (i >= 9)
                        {
                            Console.WriteLine("^(*￣(oo)￣)^ ！");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (inputNum == randomNum)
                    {
                        if (i < 5)
                        {
                            Console.WriteLine("碉堡了！");
                        }
                        else if (i < 7)
                        {
                            Console.WriteLine("666！");
                        }
                        else if (i <= 9)
                        {
                            Console.WriteLine("猜到了！");
                        }
                        else
                        {
                            //nothing to do                        
                        }
                        break;
                    }
                    //else
                    //{
                    //    //nothing to do  
                    //}
                //}
                else if (i < 9)
                {
                    Console.WriteLine("请输入一个数字！");
                }
                else
                {
                    if (i >= 9)
                    {
                        Console.WriteLine("^(*￣(oo)￣)^ ！");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
