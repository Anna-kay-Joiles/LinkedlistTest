using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LinkedlistTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Test_AddFirst()
        {
            LinkedList list = new LinkedList();
            string expectedValue = "Joe Blow";
            list.AddFirst(expectedValue);
            Assert.AreEqual(expectedValue, list.GetValue(0));
        }

        [TestMethod]
        public void Test_AddLast()
        {
            LinkedList list = new LinkedList();
            string expectedValue = "Joe Schmoe";
            list.AddLast(expectedValue);
            Assert.AreEqual(expectedValue, list.GetValue(0));
        }

        [TestMethod]
        public void Test_RemoveFirst()
        {
            LinkedList list = new LinkedList();
            list.AddFirst("Joe Blow");
            list.RemoveFirst();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void Test_RemoveLast()
        {
            LinkedList list = new LinkedList();
            list.AddLast("Joe Blow");
            list.RemoveLast();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void Test_GetValue()
        {
            LinkedList list = new LinkedList();
            list.AddFirst("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.AddLast("John Smith");
            string expectedValue = "Joe Schmoe";
            string retrievedValue = list.GetValue(1);
            Assert.AreEqual(expectedValue, retrievedValue);
        }
    }
}
