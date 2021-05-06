using ArrayLists;
using NUnit.Framework;
using System;
using System.Collections;

namespace Lists.Tests
{
    public class ArrayListTests
    {
        [TestCase(1, new int[] { 5, 10, 15 }, 10)]
        public void GetIndex_WhenIndex_ShouldValueByIndex(int index, int[] actualArray, int expected)
        {
            MyArrayList expectedArray = MyArrayList.Create(actualArray);

            int actual = expectedArray[index];

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void MyArrayListConstructor_WhenObjectOfAClassIsCreated_LengthEqualsZero(int expected)
        {
            MyArrayList actualList = new MyArrayList();
            int actual = actualList.Length;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1)]
        public void MyArrayListConstructor_WhenObjectOfAClassIsCreated_Length1(int value, int expected)
        {
            MyArrayList actualList = new MyArrayList(value);
            int actual = actualList.Length;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void MyArrayListConstructor_WhenListPassed_ShouldArgumentNullException(int[] actualArray)
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                MyArrayList.Create(null);
            });
        }

        [TestCase(3, new int[] { 1, 2 }, new int[] { 1, 2, 3 })]
        [TestCase(5, new int[] {  }, new int[] { 5 })]
        [TestCase(11, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
        public void AddValue_WhenValuePassed_AddValueToLast(int value, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.AddValueToLast(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 20, 30 }, new int[] { 1 }, new int[] { 1, 10, 20, 30 })]
        public void Add_WhenValuePassed_ShouldAddValue(int[] arrToAdd, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            foreach (var item in arrToAdd)
            {
                actual.AddValueToLast(item);
            }

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 1, 2 }, new int[] { 3, 1, 2 })]
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(1, new int[] { }, new int[] { 1 })]
        public void AddValueToStart__WhenValuePassed_AddValueToStart(int value, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.AddValueToStart(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 0, new int[] { 1, 2, 3 }, new int[] { 7, 1, 2, 3 })]
        [TestCase(5, 1, new int[] { 1, 2, 3 }, new int[] { 1, 5, 2, 3 })]
        [TestCase(3, 2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 3, 4 })]
        [TestCase(1, 0, new int[] { }, new int[] { 1 })]
        public void AddValueByIndex_WhenValueAndIndex_AddValueByIndex(int value, int index, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.AddValueByIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 5, new int[] { 1, 2, 3, 4 })]
        public void AddValueByIndex_WhenValueAndNotCorrectIndexPassed_ReturnIndexOutOfRangeException(int value, int index, int[] actualArray)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.AddValueByIndex(value, index);
            });
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 5 }, new int[] { })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1 })]
        public void RemoveLastElement_WhenMethodCalled_RemoveLast(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.RemoveLastElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { })]
        public void RemoveLastElement_WhenMethodCalledPassed_ReturnIndexOutOfRangeException(int[] actualArray, int[] expectedArray)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.RemoveLastElement();
            });
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 7 }, new int[] { })]
        [TestCase(new int[] { 5, 6 }, new int[] { 6 })]
        public void RemoveFirstElem_WhenMethodCalled_RemoveFirstElem(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.RemoveFirstElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { })]
        public void RemoveFirstElement_WhenMethodCalledPassed_ReturnIndexOutOfRangeException(int[] actualArray, int[] expectedArray)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.RemoveFirstElement();
            });
        }

        [TestCase(0, new int[] { 7, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(1, new int[] { 1, 6, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(2, new int[] { 1, 2, 5, 3, }, new int[] { 1, 2, 3 })]
        [TestCase(3, new int[] { 6, 7, 8, 9, }, new int[] { 6, 7, 8 })]
        public void RemoveElementByIndex_WhenElement_RemoveElement(int index, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.RemoveOneElementByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { }, new int[] { })]
        public void RemoveOneElementByIndex_WhenElementPassed_ReturnIndexOutOfRangeException(int index, int[] actualArray, int[] expectedArray)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.RemoveOneElementByIndex(index);
            });
        }

        [TestCase(0, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(2, new int[] { 1, 2 }, new int[] { })]
        [TestCase(4, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1 })]

        public void Remove_NElementsFromLast_WhenNElements_RemoveNElements(int nvalue, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.RemovNElementsFromLast(nvalue);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3, new int[] { 1, 3, 5, 7 })]
        public void RemovNElementsFromLast_WhenNElementsPassed_ReturnArgumentException(int nvalue, int[] actualArray)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.RemovNElementsFromLast(nvalue);
            });
        }

        [TestCase(6, new int[] { 1, 3, 5, 7 }, new int[] { 1, 3, 5 })]
        public void RemoveNElementsFromLast_WhenNElementsPassed_ReturnRemoveIndexOutOfRangeException(int nvalue, int[] actualArray, int[] expectedArray)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.RemovNElementsFromLast(nvalue);
            });
        }

        [TestCase(0, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        [TestCase(2, new int[] { 1, 2 }, new int[] { })]
        [TestCase(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5 })]

        public void RemoveNElementsFromStart_WhenNElements_RemoveNElements(int Nvalue, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.RemovNElementsFromStart(Nvalue);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1, new int[] { 1, 2, 4, 9 })]
        public void RemoveNElementsFromStart_WhenNElementsPassed_ReturnArgumentException(int nvalue, int[] actualArray)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.RemovNElementsFromStart(nvalue);
            });
        }

        [TestCase(8, new int[] { 1, 4, 13, 7 })]
        public void RemoveNElementsFromStart_WhenNElementsPassed_ReturnIndexOutOfRangeException(int nvalue, int[] actualArray)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.RemovNElementsFromStart(nvalue);
            });
        }

        [TestCase(0, 0, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(1, 1, new int[] { 1, 2, 3 }, new int[] { 1, 3 })]
        [TestCase(2, 2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 })]
        [TestCase(3, 0, new int[] { 12, 13, 14 }, new int[] { })]
        public void RemoveByIndexNElements_WhenIndexAndNElements_RemoveByIndexNElements(int nvalue, int index, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.RemoveByIndexNElements(nvalue, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5, 2, new int[] { 1, 3, 5, 7 })]
        public void RemoveNElementsByIndex_WhenNElementsPassed_ReturnArgumentException(int nvalue, int index, int[] actualArray)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.RemoveByIndexNElements(nvalue, index);
            });
        }

        [TestCase(10, 5, new int[] { 2, 3, 5, 7 })]
        public void RemoveByIndexNElements_WhenNElementsPassed_ReturnIndexOutOfRangeException(int nvalue, int index, int[] actualArray)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.RemoveByIndexNElements(nvalue, index);
            });
        }

        [TestCase(2, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1)]
        [TestCase(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, -1)]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 0)]
        [TestCase(8, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        public void GetFirstIndexByValue_WhenValue_ReturnIndex(int value, int[] actualArray, int expected)
        {
            MyArrayList array = MyArrayList.Create(actualArray);

            int actual = array.GetFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void Revers_WhenMethodCalled_ReversList(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.Revers();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 2, 3 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        public void FindMaxIndex_WhenMethodCalled_ReturnMaxIndex(int[] actualArray, int expected)
        {
            MyArrayList list = MyArrayList.Create(actualArray);
            int actual = list.FindIndexOfMaxElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 8)]
        public void FindMaxIndex_WhenMethodCalledPassed_ReturnArgumentException(int[] actualArray, int expected)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.FindIndexOfMaxElem();
            });
        }

        [TestCase(new int[] { 5, 2, 3 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }, 7)]
        public void FindMinIndex_WhenMethodCalled_ReturnMaxIndex(int[] actualArray, int expected)
        {
            MyArrayList list = MyArrayList.Create(actualArray);
            int actual = list.FindIndexOfMinElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 5)]
        public void FindMinIndex_WhenMethodCalledPassed_ReturnArgumentException(int[] actualArray, int expected)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                actual.FindIndexOfMinElem();
            });
        }

        [TestCase(new int[] { 22, 4, -6, 33 }, 33)]
        [TestCase(new int[] { 3, 5, -2, 28, 16 }, 28)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8)]
        public void FindMaxElement_WhenMethodCalled_ReturnMaxElement(int[] actualArray, int expected)
        {
            MyArrayList list = MyArrayList.Create(actualArray);
            int actual = list.FindValueOfMaxElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 52, 2, -1, 23 }, -1)]
        [TestCase(new int[] { 3, 5, 2, 28, 16 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1)]
        public void FindMinElement_WhenMethodCalled_ReturnMaxElement(int[] actualArray, int expected)
        {
            MyArrayList list = MyArrayList.Create(actualArray);
            int actual = list.FindValueOfMinElem();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 3, -1, 4, 1, 6, 8, 12 }, new int[] { -1, 1, 1, 3, 4, 6, 8, 12 })]
        [TestCase(new int[] { 5, 4, 2, 1, 3, 6, 8, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void GetAscendingSort_WhenMethodCalled_SortbyAscending(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.GetSortByAscending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 3, -1, 4, 1, 6, 8, 12 }, new int[] { 12, 8, 6, 4, 3, 1, 1, -1 })]
        [TestCase(new int[] { 5, 8, 13, 1, 6, 9, 82, 65, 14 }, new int[] { 82, 65, 14, 13, 9, 8, 6, 5, 1 })]
        public void GetDescendingSort_WhenMethodCalled_SortbyAscending(int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.GetDescendingSort();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new int[] { 7, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(2, new int[] { 1, 5, 2, 3 }, new int[] { 1, 5, 3 })]
        [TestCase(7, new int[] { 1, 2, 3, 7 }, new int[] { 1, 2, 3 })]
        [TestCase(1, new int[] { 1 }, new int[] { })]
        public void Remove_ElementByValue_WhenValue_RemoveValue(int value, int[] actualArray, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.RemoveByValueOfTheFirst(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 1, 2, 4, 2, 6, 7, 8 }, 2, new int[] { 1, 4, 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 1, 1, 3, 4, 5, 6, 8, 8 }, 10, new int[] { 1, 1, 3, 4, 5, 6, 8, 8 })]
        [TestCase(new int[] { 3, 3, 3 }, 3, new int[] { })]
        public void RemoveAllByValue_WhenValue_RemoveAllValue(int[] actualArray, int value, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList expected = MyArrayList.Create(expectedArray);

            actual.RemoveByValueAll(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 4, 5, 6 }, new int[] { 1, 2, 4, 5, 6, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 4, 5, 6 }, new int[] { 1, 4, 5, 6, 2, 3 })]
        [TestCase(new int[] { }, 0, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { }, 0, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        public void AddByIndex_WhenListAndIndexPassed_ThenAddListByIndex(int[] actualArray, int index, int[] arrayForList, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList list = MyArrayList.Create(arrayForList);
            MyArrayList expectedArrayList = MyArrayList.Create(expectedArray);

            actual.AddListByIndex(list ,index);

            Assert.AreEqual(expectedArrayList, actual);
        }

        [TestCase(new int[] { 1 }, new int[] { 4, 5, 6 }, new int[] { 1, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        public void AddListToTheEnd_WhenListPassed_AddListToTheEnd(int[] actualArray, int[] arrayForList, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList list = MyArrayList.Create(arrayForList);
            MyArrayList expectedArrayList = MyArrayList.Create(expectedArray);

            actual.AddListToTheEnd(list);

            Assert.AreEqual(expectedArrayList, actual);
        }

        [TestCase(new int[] { 5, 10, 15, 30 }, new int[] { })]
        public void AddListToTheEnd_WhenListPassed_ReturnArgumentException(int[] actualArray, int[] arrayForList)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                MyArrayList list = MyArrayList.Create(arrayForList);
                actual.AddListToTheEnd(list);
            });
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 6, 4, 9 }, new int[] { 7, 8, 4 }, new int[] { 7, 8, 4, 6, 4, 9 })]
        public void AddListToStart_WhenListPassed_AddListToStart(int[] actualArray, int[] arrayForList, int[] expectedArray)
        {
            MyArrayList actual = MyArrayList.Create(actualArray);
            MyArrayList list = MyArrayList.Create(arrayForList);
            MyArrayList expectedArrayList = MyArrayList.Create(expectedArray);

            actual.AddListToStart(list);

            Assert.AreEqual(expectedArrayList, actual);
        }

        [TestCase(new int[] { 3, 4, 32, 40 }, new int[] { })]
        public void AddListToStart_WhenListPassed_ReturnArgumentException(int[] actualArray, int[] arrayForList)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MyArrayList actual = MyArrayList.Create(actualArray);
                MyArrayList list = MyArrayList.Create(arrayForList);
                actual.AddListToStart(list);
            });
        }

        [TestCase(new int[] { 2, 4, 6 }, "2 4 6")]
        [TestCase(new int[] { 5 }, "5")]
        [TestCase(new int[] { }, "")]
        public void ToString_WhenArrayListPassed_ShouldString(int[] array, string expected)
        {
            MyArrayList arrayList = MyArrayList.Create(array);

            string actual = arrayList.ToString();

            Assert.AreEqual(expected, actual);
        }


    }
}