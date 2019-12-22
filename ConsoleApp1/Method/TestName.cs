using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    static class TestName
    {
        static TestName()
        {
            TestName.BedWords = new List<string> { "17bang", "admin", "管理员" };
        }
        internal static IList<string> BedWords { get; set; }
        public static bool TestOfName(string name)
        {
            for (int i = 0; i < BedWords.Count; i++)
            {
                if (name.Contains(BedWords[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
