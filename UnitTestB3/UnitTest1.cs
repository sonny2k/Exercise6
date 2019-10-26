using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using B3;

namespace UnitTestB3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEnqueue()
        {
            Queue q = new Queue(10);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            Assert.AreEqual(3, q.Count());
        }

        [TestMethod]
        public void TestDequeue()
        {
            Queue q = new Queue(10);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            Assert.AreEqual(5, q.Dequeue());
            Assert.AreEqual(6, q.Dequeue());
            Assert.AreEqual(1, q.Count());
        }

        [TestMethod]
        public void TestPeekQueue()
        {
            Queue q = new Queue(10);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            Assert.AreEqual(5, q.PeekQueue());
            Assert.AreEqual(3, q.Count());
        }

        [TestMethod]
        public void TestClear()
        {
            Queue q = new Queue(10);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            q.Clear();
            Assert.AreEqual(0, q.Count());
        }
    }
}
