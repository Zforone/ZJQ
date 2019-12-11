using ConsoleApp1.Method;
using NUnit.Framework;
using System;

namespace Tests
{
    public class StackTest
    {
        Stack stack = new Stack(5);

        [SetUp]
        public void Setup()
        {  
            
        }

        [Test]
        public void PopTest()
        {
            
            stack.Pop(1);
            Assert.AreEqual(stack._arr[0],1);

            
            stack.Pop(5,6);
            Assert.AreEqual(stack._arr[1], 5);
            Assert.AreEqual(stack._arr[2], 6);

            
            stack.Pop(8,9);
            Assert.AreEqual(stack._arr[3], 8);
            Assert.AreEqual(stack._arr[4], 9);
        }
        [Test]
        public void PushTest()
        {
            //stack.Push()
        }
    }
}