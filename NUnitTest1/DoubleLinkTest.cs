using ConsoleApp1.Method;
using NUnit.Framework;

namespace Tests
{
    public class DoubleLinkTest
    {
        DoubleLink node1, node2, node3, node4, node5, node6;

        [SetUp]
        public void Setup()
        {  
            node1 = new DoubleLink(1);
            node2 = new DoubleLink(2);
            node3 = new DoubleLink(3);
            node4 = new DoubleLink(4);
            node5 = new DoubleLink(5);
            node6 = new DoubleLink(6);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            //node6.Next = null;

            node6.Previous = node5;
            node5.Previous = node4;
            node4.Previous = node3;
            node3.Previous = node2;
            node2.Previous = node1;
            //node1.Previous = null;
        }

        [Test]
        public void FindBy()
        {
            Assert.AreEqual(node1.FindBy(1), node1);
            Assert.AreEqual(node3.FindBy(3), node3);
            Assert.AreEqual(node6.FindBy(6), node6);
        }

        [Test]
        public void InsertAfter()
        { 
            DoubleLink InsertedNodeInMiddle = new DoubleLink(11);
            InsertedNodeInMiddle.InsertAfter(node3);
            Assert.AreEqual(InsertedNodeInMiddle, node3.Next);
            Assert.AreEqual(InsertedNodeInMiddle, node4.Previous);
            Assert.AreEqual(node4, InsertedNodeInMiddle.Next);
            Assert.AreEqual(node3, InsertedNodeInMiddle.Previous);

            DoubleLink InsertedNodeInLast = new DoubleLink(12);
            InsertedNodeInLast.InsertAfter(node6);
            Assert.AreEqual(node6, InsertedNodeInLast.Previous);
            Assert.AreEqual(InsertedNodeInLast.Next, null);
            Assert.AreEqual(node6.Next, InsertedNodeInLast);

            
        }

        [Test]
        public void InsterBefore()
        {
            DoubleLink InsertedNodeInMiddle = new DoubleLink(21);
            InsertedNodeInMiddle.InsterBefore(node4);
            Assert.AreEqual(node4.Previous, InsertedNodeInMiddle);
            Assert.AreEqual(node3.Next, InsertedNodeInMiddle);
            Assert.AreEqual(InsertedNodeInMiddle.Previous, node3);
            Assert.AreEqual(InsertedNodeInMiddle.Next, node4);

            DoubleLink InsertedNodeInFrist = new DoubleLink(22);
            InsertedNodeInFrist.InsterBefore(node1);
            Assert.AreEqual(InsertedNodeInFrist.Next, node1);
            Assert.AreEqual(InsertedNodeInFrist.Previous, null);
            Assert.AreEqual(node1.Previous, InsertedNodeInFrist);

        }

        [Test]
        public void Delete()
        {
            node3.Delete();
            Assert.AreEqual(node2.Next, node4);
            Assert.AreEqual(node4.Previous, node2);

            node1.Delete();
            Assert.AreEqual(node2.Previous, null);

            node6.Delete();
            Assert.AreEqual(node5.Next, null);

        }

        [Test]
        public void Swap()
        {
            node3.Swap(node3, node4);
            Assert.AreEqual(node3.Previous, node4);
            Assert.AreEqual(node3.Next, node5);
            Assert.AreEqual(node5.Previous, node3);
            Assert.AreEqual(node4.Next, node3);
            Assert.AreEqual(node4.Previous, node2);
            Assert.AreEqual(node2.Next, node4);

            node1.Swap(node1, node6);
            Assert.AreEqual(node1.Previous, node5);
            Assert.AreEqual(node1.Next, null);
            Assert.AreEqual(node5.Next, node1);
            Assert.AreEqual(node6.Next, node2);
            Assert.AreEqual(node6.Previous, null);
            Assert.AreEqual(node2.Previous, node6);

        }
    }
}