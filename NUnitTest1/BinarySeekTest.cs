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
            
            //Assert.AreEqual(seek.BinaryOfSeek(arr, 99, arr.Length), 1);
            //Assert.AreEqual(seek.BinaryOfSeek(arr, 111, arr.Length), 2);
            //Assert.AreEqual(seek.BinaryOfSeek(arr, 222, arr.Length), 3);
            //Assert.AreEqual(seek.BinaryOfSeek(arr, 333, arr.Length), 4);
            //Assert.AreEqual(seek.BinaryOfSeek(arr, 400, arr.Length), 5);
            //Assert.AreEqual(seek.BinaryOfSeek(arr, 555, arr.Length), 6);

        }
    }
}