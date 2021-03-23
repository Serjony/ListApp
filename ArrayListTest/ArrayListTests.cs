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
        public void AddValue_WhenValuePassed_AddValueToLast(int value, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.AddValueToLast(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 1, 2 }, new int[] { 3, 1, 2 })]
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(1, new int[] { 1, 2, 35 }, new int[] { 1, 1, 2, 35 })]
        public void AddValueToStart_(int value, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.AddValueToStart(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 0, new int[] { 1, 2, 3 }, new int[] { 7, 1, 2, 3 })]
        [TestCase(5, 1, new int[] { 1, 2, 3 }, new int[] { 1, 5, 2, 3 })]
        [TestCase(3, 2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 3, 4 })]
        public void AddValueByIndex_WhenValueAndIndex_AddValueByIndex(int value, int index, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.AddValueByIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveLast_WhenMethodCalled_ThenRemoveLast(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemoveLastElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveFirstElem_WhenMethodCalled_RemoveFirstElem(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemoveFirstElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 7, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(1, new int[] { 1, 6, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(2, new int[] { 1, 2, 5, 3, }, new int[] { 1, 2, 3 })]
        public void RemoveElementByIndex_WhenElement_RemoveElement(int index, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemoveOneElementByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3 })]
        [TestCase(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2 })]
        
        public void Remove_NElementsFromLast_WhenNElements_RemoveNElements(int Nvalue, int[] actualArray, int[] expectedArray)
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

        public void RemoveNElementsFromStart_WhenNElements_RemoveNElements(int Nvalue, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemovNElementsFromStart(Nvalue);
            

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(1, 1, new int[] { 1, 2, 3 }, new int[] { 1, 3 })]
        [TestCase(2, 2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 })]

        public void RemoveByIndexNElements_WhenIndexAndNElements_RemoveByIndexNElements(int Nvalue, int index, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemoveByIndexNElements(Nvalue, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1)]
        [TestCase(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },  -1)]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 0)]
        [TestCase(8, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        public void GetFirstIndexByValue_WhenValue_ReturnIndex(int value, int[] actualArray, int expected)
        {
            MyArrayList array = new MyArrayList(actualArray);

            int actual = array.GetFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void Revers_WhenMethodCalled_ReversList(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.GetRevers();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        public void FindMaxIndex_WhenMethodCalled_ReturnMaxIndex(int[] actualArray, int expected)
        {
            MyArrayList list = new MyArrayList(actualArray);
            int actual = list.FindIndexOfMaxElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }, 7)]
        public void FindMinIndex_WhenMethodCalled_ReturnMaxIndex(int[] actualArray, int expected)
        {
            MyArrayList list = new MyArrayList(actualArray);
            int actual = list.FindIndexOfMinElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        [TestCase(new int[] { 3, 5, -2, 28, 16 }, 3)]
        public void FindMaxElement_WhenMethodCalled_ReturnMaxElement(int[] actualArray, int expected)
        {
            MyArrayList list = new MyArrayList(actualArray);
            int actual = list.FindValueOfMaxElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 0)]
        [TestCase(new int[] { 3, 5, -2, 28, 16 }, 2)]
        public void FindMinElement_WhenMethodCalled_ReturnMaxElement(int[] actualArray, int expected)
        {
            MyArrayList list = new MyArrayList(actualArray);
            int actual = list.FindValueOfMinElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 3, -1, 4, 1, 6, 8, 12 }, new int[] { -1, 1, 1, 3, 4, 6, 8, 12 })]
        public void GetAscendingSort_WhenMethodCalled_SortbyAscending(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.GetSortByAscending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 3, -1, 4, 1, 6, 8, 12 }, new int[] { 12, 8, 6, 4, 3, 1, 1, -1 })]
        public void GetDescendingSort_WhenMethodCalled_SortbyAscending(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.GetDescendingSort();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new int[] { 7, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(2, new int[] { 1, 5, 2, 3 }, new int[] { 1, 5, 3 })]
        [TestCase(7, new int[] { 1, 2, 3, 7 }, new int[] { 1, 2, 3 })]

        public void Remove_ElementByValue_WhenValue_RemoveValue(int value, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemoveByValueOfTheFirst(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 1, 2, 4, 2, 6, 7, 8 }, 2, new int[] { 1, 4, 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 1, 1, 3, 4, 5, 6, 8, 8 }, 10, new int[] { 1, 1, 3, 4, 5, 6, 8, 8 })]
        [TestCase(new int[] { 3, 3, 3 }, 3, new int[] { })]
        public void RemoveAllByValue_WhenValue_RemoveAllValue(int[] actualArray, int value, int[] expectedArray)
        {
            MyArrayList actual = new MyArrayList(actualArray);
            MyArrayList expected = new MyArrayList(expectedArray);

            actual.RemoveByValueAll(value);

            Assert.AreEqual(expected, actual);
        }

    }
}