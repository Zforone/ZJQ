using ConsoleApp1.Method;
using NUnit.Framework;
using System;

namespace Tests
{
    public class GetMaxTest
    {

        [SetUp]
        public void Setup()
        {  
            
        }

        [Test]
        public void GetMaxInArrayTest()
        {
            GetMax getMax = new GetMax();
            double[] score1 = { 88.5, 95, 86, 99, 98 };
            double[] score2 = { 88.5, 95, 100, 99, 98 };
            double[] score3 = { 88.5, 95, 86, 66, 98 };
            double[] score4 = { 0, 95, 86, 99, 98 };

            Assert.AreEqual(getMax.GetMaxInArray(score1), 99);
            Assert.AreEqual(getMax.GetMaxInArray(score2), 100);
            Assert.AreEqual(getMax.GetMaxInArray(score3), 98);
            Assert.AreEqual(getMax.GetMaxInArray(score4), 99);


        }
    }
}