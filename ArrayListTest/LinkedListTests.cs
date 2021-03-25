using Lists;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lists.Tests
{
    class LinkedListTests
    {
        [TestCase(3, new int[] { 1, 2 }, new int[] { 1, 2, 3 })]
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(1, new int[] { 1, 2, 35 }, new int[] { 1, 2, 35, 1 })]
        public void AddValue_WhenValuePassed_AddValueToLast(int value, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);

            actual.Add(value);

            Assert.AreEqual(new LinkedList(expectedArray), actual);
        }

        [TestCase(3, new int[] { 1, 2 }, new int[] { 3, 1, 2 })]
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(1, new int[] { 1, 2, 35 }, new int[] { 1, 1, 2, 35 })]
        public void AddValueToStart__WhenValuePassed_AddValueToStart(int value, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);

            actual.AddValueToStart(value);

            Assert.AreEqual(new LinkedList(expectedArray), actual);
        }

        [TestCase(7, 0, new int[] { 1, 2, 3 }, new int[] { 7, 1, 2, 3 })]
        [TestCase(5, 1, new int[] { 1, 2, 3 }, new int[] { 1, 5, 2, 3 })]
        [TestCase(3, 2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 3, 4 })]
        public void AddValueByIndex_WhenValueAndIndex_AddValueByIndex(int value, int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.AddValueByIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3})]
        public void RemoveLastElem_WhenElemem_RemoveLastElem(int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveLastElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
        public void RemoveFirst_WhenElemem_RemoveFirst(int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveFirst();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 1 }, new int[] { })]
        [TestCase(0, new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 4, 5 })]
        [TestCase(4, new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2 })]

        public void RemoveByIndexlements_WhenIndex_RemoveByIndexElements(int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, new int[] { 1, 2, 3, 4, 5 }, new int[] { })]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3 })]
        [TestCase(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2 })]

        public void Remove_NElementsFromLast_WhenNElements_RemoveNElements(int nvalue, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemovNElementsFromLast(nvalue);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, new int[] { 1, 2, 3, 4, 5 }, new int[] { })]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
        [TestCase(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5 })]

        public void RemoveNElementsFromStart_WhenNElements_RemoveNElements(int nvalue, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemovNElementsFromStart(nvalue);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(1, 1, new int[] { 1, 2, 3 }, new int[] { 1, 3 })]
        [TestCase(2, 2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5 })]

        public void RemoveByIndexNElements_WhenIndexAndNElements_RemoveByIndexNElements(int nvalue, int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveByIndexNElements(nvalue, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1)]
        [TestCase(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, -1)]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 0)]
        [TestCase(8, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        public void GetIndexByValue_WhenValue_ReturnIndex(int value, int[] actualArray, int expected)
        {
            LinkedList index = new LinkedList(actualArray);
            int actual = index.GetIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 2, 4, 5, 6, 7, 8 })]
        [TestCase(10, 0, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 10, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(1, 7, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 1 })]
        
        public void GetChangeByIndex_WhenValue_ReturnIndex(int value, int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.GetChangeByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(2, 2, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 2, 4, 5, 6, 7, 8 })]
        //[TestCase(10, 0, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 10, 2, 3, 4, 5, 6, 7, 8 })]
        //[TestCase(1, 7, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 1 })]

        //public void Revers(int value, int index, int[] actualArray, int[] expectedArray)
        //{
        //    LinkedList actual = new LinkedList(actualArray);
        //    LinkedList expected = new LinkedList(expectedArray);

        //    actual.GetChangeByIndex(index, value);

        //    Assert.AreEqual(expected, actual);
        //}

        [TestCase(new int[] { 2, 3, 6, 5 }, 2)]
        [TestCase(new int[] { 8, 2, 5, 5, 1 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 1, 5, 6, 7, 9 }, 7)]
        public void FindMaxIndex_WhenMethodCalled_ReturnMaxIndex(int[] actualArray, int expected)
        {
            LinkedList index = new LinkedList(actualArray);
            int actual = index.FindIndexOfMaxElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 1 }, 6)]
        [TestCase(new int[] { 2, 6, 1, 4, 5 }, 2)]
        public void FindMinIndex_WhenMethodCalled_ReturnMinIndex(int[] actualArray, int expected)
        {
            LinkedList index = new LinkedList(actualArray);
            int actual = index.FindIndexOfMinElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 0, 3, 4, 5, 6, 7, 9 }, 6)]
        [TestCase(new int[] { 2, 6, 1, 4, 5 }, 1)]
        public void FindValueOfMaxElem_WhenMethodCalled_ReturnMaxIndex(int[] actualArray, int expected)
        {
            LinkedList index = new LinkedList(actualArray);
            int actual = index.FindValueOfMaxElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 1 }, 6)]
        [TestCase(new int[] { 2, 6, 1, 4, 5 }, 2)]
        public void FindValueOfMinElem_WhenMethodCalled_ReturnValueOfMinElem(int[] actualArray, int expected)
        {
            LinkedList index = new LinkedList(actualArray);
            int actual = index.FindValueOfMinElem();

            Assert.AreEqual(expected, actual);
        }
    }
}
