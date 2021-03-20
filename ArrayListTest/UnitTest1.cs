using ArrayLists;
using NUnit.Framework;
using System.Collections;

namespace Tests
{
    public class Tests
    {
        [TestCase(1, 2)]

        public void RemoveByIndexNElements_WhenPassed_ReturnArr(int index, int Nvalue, int mockNumber, int[] expected)
        {
            MyArrayList arrayList = new MyArrayList();//mock
            arrayList.RemoveByIndexNElements(index, Nvalue);

            Assert.AreEqual(expected, arrayList);
        }


    }
}