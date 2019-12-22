using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    public static class TestPassWord
    {
        public static bool HasUpper(string passWord,Func<byte,bool> check)
        {
            byte[] str = Encoding.Default.GetBytes(passWord);
            byte num;
            for (int i = 0; i < str.Length; i++)
            {                
                num = str[i];
                if (check(num))
                {
                    return true;
                }               
            }
            return false;           
        }
        public static bool HasLower(string passWord, Func<byte, bool> check)
        {
            byte[] str = Encoding.Default.GetBytes(passWord);
            byte num;
            for (int i = 0; i < str.Length; i++)
            {
                num = str[i];
                if (check(num))
                {
                    return true;
                }               
            }
            return false;
        }
        public static bool HasNumber(string passWord, Func<byte, bool> check)
        {
            byte[] str = Encoding.Default.GetBytes(passWord);
            byte num;
            for (int i = 0; i < str.Length; i++)
            {
                num = str[i];
                if (check(num))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HasOther(string passWord, Func<byte, bool> check)
        {
            byte[] str = Encoding.Default.GetBytes(passWord);
            byte num;
            for (int i = 0; i < str.Length; i++)
            {
                num = str[i];
                if (check(num))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Result(string passWord)
        {
            return TestPassWord.HasLower(passWord, c => c >= 65 && c <= 90)
                && TestPassWord.HasUpper(passWord, c => c >= 97 && c <= 122)
                && TestPassWord.HasNumber(passWord, c => c >= 48 && c <= 57)
                && TestPassWord.HasOther(passWord, c => (c >= 33 && c <= 47)
                                                     || (c >= 58 && c <= 64)
                                                     || (c >= 91 && c <= 96)
                                                     || (c >= 123 && c <= 126)
                                        );
        }
    }
}
