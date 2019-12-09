using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IAgree
    {
        void Agree(User voter );
        void Disagree(User voter);
    }
}
