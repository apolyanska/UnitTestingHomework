using System;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1.DynamicList.Tests
{
    [TestClass]
    public class DynamicListTests
    {
        private DynamicList<int> dynamListTest;

        [TestInitialize]
        public void DynamicListInitilizer()
        {
            this.dynamListTest = new DynamicList<int>();
            for (int i = 0; i < 5; i++)
            {
                dynamListTest.Add(i);
            }
        }

        [TestMethod]
        public void TestCount()
        {
            dynamListTest.Add(5);
            Assert.AreEqual(6, dynamListTest.Count);
        }

        [TestMethod]
        [ExpectedException (typeof (ArgumentOutOfRangeException))]
        public void TestSetInvalidIndex()
        {
            var index = dynamListTest[10];
        }

        [TestMethod]
        public void TestAddItemAtTheEndOfList()
        {
            for (int i = 0; i < 5; i++)
            {
                dynamListTest.Add(i);
                Assert.AreEqual(i, dynamListTest[i], "Does not add the right item at the end of the list.");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveElementAtNegativeIndex()
        {
            dynamListTest.RemoveAt(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveElementAtGraterThanCountIndex()
        {
            dynamListTest.RemoveAt(dynamListTest.Count + 1);
        }

        [TestMethod]
        public void TestRemoveElementsAtGivenIndex()
        {
            dynamListTest.RemoveAt(2);
            Assert.AreEqual(3, dynamListTest[2], "Returns wrong element after removal.");
        }

        [TestMethod]
        public void TestRemoveExistingElementAndReturnsIndex()
        {
            Assert.AreEqual(3, dynamListTest.Remove(3));
        }

        [TestMethod]
        public void TestRemoveUneistingElementAndReturnsIndex()
        {
            Assert.AreEqual(-1, dynamListTest.Remove(7));
        }

        [TestMethod]
        public void TestSearchOfExistingElementAndReturnFirstOccurenceIndex()
        {
            Assert.AreEqual(3, dynamListTest.IndexOf(3));
        }

        [TestMethod]
        public void TestSearchOfUnexistingElementAndReturnNegativeIndex()
        {
            Assert.AreEqual(-1, dynamListTest.IndexOf(7));
        }

        [TestMethod]
        public void TestIfListContainsExistingElement()
        {
            Assert.IsTrue(dynamListTest.Contains(2));
        }

        [TestMethod]
        public void TestIfListContainsUnexistingElement()
        {
            Assert.IsFalse(dynamListTest.Contains(10));
        }

    }
}
