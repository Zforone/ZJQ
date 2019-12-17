using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    public static class TestPassWord
    {
        private static bool _resutleOfTestPassWord;
        public static bool HasUpper(string passWord)
        {
            byte[] str = Encoding.Default.GetBytes(passWord);
            int num;
            for (int i = 0; i < str.Length; i++)
            {
                num = str[i];
                if (num >= 65 && num <= 90)
                {
                    _resutleOfTestPassWord = true;
                    break;
                }
                else
                {
                    _resutleOfTestPassWord=false;
                }
            }
            return _resutleOfTestPassWord;
           
        }
        public static bool HasLower(string passWord)
        {
            byte[] str = Encoding.Default.GetBytes(passWord);
            int num;

            for (int i = 0; i < str.Length; i++)
            {
                num = str[i];
                if (num >= 97 && num <= 122)
                {
                    _resutleOfTestPassWord = true;
                    break;
                }
                else
                {
                    _resutleOfTestPassWord = false;
                }
            }
            return _resutleOfTestPassWord;
        }
        public static bool HasNumber(string passWord)
        {
            byte[] str = Encoding.Default.GetBytes(passWord);
            int num;
            for (int i = 0; i < str.Length; i++)
            {
                num = str[i];
                if (num >= 48 && num <= 57)
                {
                    _resutleOfTestPassWord = true;
                    break;
                }
                else
                {
                    _resutleOfTestPassWord = false;
                }
            }
            return _resutleOfTestPassWord;
        }
        public static bool HasOther(string passWord)
        {
            byte[] str = Encoding.Default.GetBytes(passWord);
            int num;
            for (int i = 0; i < str.Length; i++)
            {
                num = str[i];
                if (num >= 33 && num <= 47)
                {
                    _resutleOfTestPassWord = true;
                    break;
                }
                else if (num >= 58 && num <= 64)
                {
                    _resutleOfTestPassWord = true;
                    break;
                }
                else if (num >= 91 && num <= 96)
                {
                    _resutleOfTestPassWord = true;
                    break;
                }
                else if (num >= 123 && num <= 126)
                {
                    _resutleOfTestPassWord = true;
                    break;
                }
                else
                {
                    _resutleOfTestPassWord = false;
                }
            }
            return _resutleOfTestPassWord;
        }
    }
}
