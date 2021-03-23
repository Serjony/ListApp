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

            actual.AddValueByIndex(value, index);

            Assert.AreEqual(new LinkedList(expectedArray), actual);
        }
    }
}
