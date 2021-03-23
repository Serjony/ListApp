using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayListTest
{
    class LinkedListTests
    {
        [TestCase(3, new int[] { 1, 2 }, new int[] { 1, 2, 3 })]
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(1, new int[] { 1, 2, 35 }, new int[] { 1, 2, 35, 1 })]
        public void AddValue_WhenValuePassed_AddValueToLast(int value, int[] actualArray, int[] expectedArray)
        {
           
        }
    }
}
