using ConsoleApp1.Method;
using NUnit.Framework;
using System;

namespace Tests
{
    public class StackTest
    {
        [SetUp]
        public void Setup()
        {  
            
        }

        [Test]
        public void PopTest()
        {
            Stack stack = new Stack(3);
            stack.Pop("A");
            stack.Pop("C","B");
            Assert.AreEqual(stack._arr[0], "A");
            Assert.AreEqual(stack._arr[0], "C");
            Assert.AreEqual(stack._arr[1], "B");

        }
        [Test]
        public void PushTest()
        {
            //stack.Push()
        }
    }
}