using ConsoleApp1.Method;
using NUnit.Framework;
using System;

namespace Tests
{
    public class PrimeNumberTest
    {
        [SetUp]
        public void Setup()
        {  
            
        }

        [Test]
        public void PrimeTest()
        {
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.SeekPrimeNumber();
            Assert.AreEqual(primeNumber.PrimeList[0], 1);
            Assert.AreEqual(primeNumber.PrimeList[2], 3);
            Assert.AreEqual(primeNumber.PrimeList[3], 5);
            Assert.AreEqual(primeNumber.PrimeList[4], 7);
            Assert.AreEqual(primeNumber.PrimeList[5], 11);

        }

    }
}