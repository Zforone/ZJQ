using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //声明一个令牌管理（TokenManager）类：
        //使用私有的Token枚举_tokens存储所具有的权限
        //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和查看其权限
    internal class TokenManager
    {
        private Token _tokens { get; set; } /*= Token.SuperAdmin ;*/
        public void Add( Token token)
        {            
            _tokens = _tokens | token; 
        }
        public void Remove( Token token)
        {
                _tokens = _tokens ^ token;
        }
        public Token Has()
        {            
            return _tokens;            
        }
    }     
}
