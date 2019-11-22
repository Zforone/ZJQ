using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //●帮帮币版块，定义一个类HelpMoney,包含你认为应该包含的字段和方法
    class HelpMoney :Entity 
    {
        //将之前User/Problem/HelpMoney类的字段封装成属性，
        internal HelpMoney(int integrals)
        {

        }
        public int _BangBangCoins;
        public int BangBangCoins { get; set; }

        public DateTime _DateTime;
        public DateTime DateTime { get; set; }

        public string _Type;
        public string Type { get; set; }

        public int _Changes;
        public int Changes { get; set; }

        public string _Notes;
        public string Notes { get; set; }

        internal void changeCoins(int changeNum)
        {
            
        }
    }
}
