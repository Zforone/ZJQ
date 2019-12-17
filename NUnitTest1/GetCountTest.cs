using ConsoleApp1;
using ConsoleApp1.Method;
using NUnit.Framework;
using System;

namespace Tests
{
    public class GetCountTest
    {
        [SetUp]
        public void Setup()
        {  
            
        }

        [Test]
        public void TheGetCountTest()
        {
            string example1 = "123456";
            string example2 = "123333";
            string example3 = "145456";
            string example4 = "123123";
            string example5 = "17bang17";
            string example6 = "17bangbang";
            string example7 = "ԴջԴջ";
            string example8 = "ԴջԴ";
            Assert.AreEqual(Function.GetCount(example1, "1"), 1);
            Assert.AreEqual(Function.GetCount(example2, "3"), 4);
            Assert.AreEqual(Function.GetCount(example3, "45"), 2);
            Assert.AreEqual(Function.GetCount(example4, "123"), 2);
            Assert.AreEqual(Function.GetCount(example5, "17"), 2);
            Assert.AreEqual(Function.GetCount(example6, "17"), 1);
            Assert.AreEqual(Function.GetCount(example7, "Դջ"), 2);
            Assert.AreEqual(Function.GetCount(example8, "ջ"), 1);
        }

    }
}