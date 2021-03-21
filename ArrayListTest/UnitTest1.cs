using ArrayLists;
using NUnit.Framework;
using System.Collections;

namespace Tests
{
    public class Tests
    {
        [TestCase(3, new int[] { 1, 2 }, new int[] { 1, 2, 3 })]
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(1, new int[] { 1, 2, 35 }, new int[] { 1, 2, 35, 1 })]
        public void Add_ValueToEnd(int value, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.AddValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 0, new int[] { 1, 2, 3 }, new int[] { 7, 1, 2, 3 })]
        [TestCase(5, 1, new int[] { 1, 2, 3 }, new int[] { 1, 5, 2, 3 })]
        [TestCase(3, 2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 3, 4 })]
        public void Add_ValueByIndex(int value, int index, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.AddValueByIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 8, 1, 2 }, new int[] { 1, 2 })]
        //[TestCase(new int[] { 7, 1, 2 }, new int[] { 1, 2 })]
        //[TestCase(new int[] { 6, 1, 2 }, new int[] { 1, 2 })]
        //public void Remove_ElementFromStart(int[] actualArray, int[] expectedArray)
        //{
        //    MyArrayList actual = new MyArrayList(actualArray);
        //    MyArrayList expected = new MyArrayList(expectedArray);

        //    actual.RemoveFirstElement();

        //    Assert.AreEqual(expected, actual);

        //    //[TestCase(1, 2)]

        //    //public void RemoveByIndexNElements_WhenPassed_ReturnArr(int index, int Nvalue, int mockNumber, int[] expected)
        //    //{
        //    //    MyArrayList arrayList = new MyArrayList();//mock
        //    //    arrayList.RemoveByIndexNElements(index, Nvalue);

        //    //    Assert.AreEqual(expected, arrayList);
        //    //}


        //}

        [TestCase(0, new int[] { 7, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(1, new int[] { 1, 6, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(2, new int[] { 1, 2, 5, 3, }, new int[] { 1, 2, 3 })]
        public void Remove_ElementByIndex(int index, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemoveOneElementByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3 })]
        [TestCase(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2 })]
        
        public void Remove_NElementsFromEnd(int Nvalue, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemovNElementsFromLast(Nvalue);
            

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
        [TestCase(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5 })]

        public void RemoveNElementsFromStart(int Nvalue, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemovNElementsFromStart(Nvalue);
            

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(1, 1, new int[] { 1, 2, 3 }, new int[] { 1, 3 })]
        [TestCase(2, 2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 })]

        public void RemoveNElementByIndex(int Nvalue, int index, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemoveByIndexNElements(Nvalue, index);

            Assert.AreEqual(expected, actual);
        }

    }
}