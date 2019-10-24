using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using B2;

namespace UnitTestB2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPush()
        {
            //Push 3 items, check Count
            Stack s = new Stack();
            s.Push("5");
            s.Push("7");
            s.Push("9");
            Assert.AreEqual(3, s.Count());
        }

        [TestMethod]
        public void TestPop()
        {
            // Push some items, check the poped value
            Stack s = new Stack();
            s.Push("1");
            s.Push("3");
            s.Push("5");
            Assert.AreEqual("5", s.Pop());
            Assert.AreEqual("3", s.Pop());
            Assert.AreEqual(1, s.Count());
        }

        [TestMethod]
        public void TestPeek()
        {
            // Push some items, check the peeked value and count
            Stack s = new Stack();
            s.Push("1");
            s.Push("3");
            s.Push("5");
            Assert.AreEqual("5", s.Peek());
            Assert.AreEqual(3, s.Count());
        }

        [TestMethod]
        public void TestClear()
        {
            // invoke Clear and check Count
            Stack s = new Stack();
            s.Push("1");
            s.Push("3");
            s.Push("5");
            s.Clear();
            Assert.AreEqual(0, s.Count());
        }
    }
}
