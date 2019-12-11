using ConsoleApp1.Method;
using NUnit.Framework;
using System;

namespace Tests
{
    public class BinarySeekTest
    {

        [SetUp]
        public void Setup()
        {  
            
        }

        [Test]
        public void BinarySeek()
        {
            BinarySeek seek = new BinarySeek();
            int[] arr = { 99, 111, 222, 333, 400, 555 };
            //Random num = new Random();
            //int randomNum = num.Next(0, 6);
            //double i = arr[randomNum];
            seek.BinaryOfSeek<int>(arr, 99, arr.Length);
            Assert.AreEqual(seek.SeekedNumIndex, 1);

            seek.BinaryOfSeek<int>(arr, 111, arr.Length);
            Assert.AreEqual(seek.SeekedNumIndex, 2);

            seek.BinaryOfSeek<int>(arr, 222, arr.Length);
            Assert.AreEqual(seek.SeekedNumIndex, 3);
 

        }
    }
}