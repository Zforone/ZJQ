using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace MethodTest
{
    [TestClass]
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
            DoubleLink node1 = new DoubleLink();
            DoubleLink node2 = new DoubleLink();
            DoubleLink node3 = new DoubleLink();
            DoubleLink node4 = new DoubleLink();

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            node4.Previous = node3;
            node3.Previous = node2;
            node2.Previous = node1;
        }

        [TestMethod]
        public void InsertAfter()
        {

        }
        [TestMethod]
        public void InsterBefore()
        {
            
            

            
        }
        [TestMethod]
        public void Delete()
        {

        }
        [TestMethod]
        public void Swap()
        {

        }
    }
}
