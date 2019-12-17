using ConsoleApp1;
using ConsoleApp1.Method;
using NUnit.Framework;
using System;

namespace Tests
{
    public class mimicJoinTest
    {
        [SetUp]
        public void Setup()
        {  
            
        }

        [Test]
        public void mimicJoinOfTest()
        {
            Assert.AreEqual(Function.mimicJoin('+', "1", "2", "3"), "1+2+3");
            Assert.AreEqual(Function.mimicJoin('*', "1", "2", "3","f"), "1*2*3*f");
            Assert.AreEqual(Function.mimicJoin('-', "1", "2", "령며"), "1-2-령며");
            Assert.AreEqual(Function.mimicJoin('/', "1", "2", "3","*"), "1/2/3/*");
            Assert.AreEqual(Function.mimicJoin('@', "1", "2", "3","@"), "1@2@3@@");

        }

    }
}