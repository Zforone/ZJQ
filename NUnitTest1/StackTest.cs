using ConsoleApp1.Method;
using NUnit.Framework;
using System;

namespace Tests
{
    public class StackTest
    {
        Stack stack = new Stack(3);
        [SetUp]
        public void Setup()
        {  
            
        }

        [Test]
        public void PopTest()
        {
            
            stack.Pop("A");
            stack.Pop("C","B");
            Assert.AreEqual(stack._arr[0], "A");
            Assert.AreEqual(stack._arr[1], "C");
            Assert.AreEqual(stack._arr[2], "B");

        }
        [Test]
        public void PushTest()
        {
            stack.Push("A");
            stack.Push("C");
            stack.Push("B");
            Assert.AreEqual(stack._arr[2], null);
            Assert.AreEqual(stack._arr[1], null);
            Assert.AreEqual(stack._arr[0], null);


        }
    }
}