using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._17bang
{
    //评价（Appraise）类
    public interface IAppraise
    {
        void Agree(User voter);
        void DisAgree(User voter);
    }
}
