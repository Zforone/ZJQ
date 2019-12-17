using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Method
{
    static class TestName
    {
        internal static IList<string> BedWords { get; set; }
        private static bool _resutleOfTestName;
        public static bool TestOfName(string name)
        {
            for (int i = 0; i < BedWords.Count; i++)
            {
                if (name.Contains(BedWords[i]))
                {
                    _resutleOfTestName = true;
                    break;
                }
                else
                {
                    continue;
                }

            }
            return _resutleOfTestName;
        }
    }
}
