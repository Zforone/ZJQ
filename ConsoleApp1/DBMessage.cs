using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("ISendMessage");
        }
    }
}
