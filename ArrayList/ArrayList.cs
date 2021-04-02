﻿using System;

namespace ArrayLists
{
    public class MyArrayList
    {
        public int Length { get; private set; }

        public int this[int index]
        {
            get
            {
                if ((index < Length) && (index >= 0))
                {
                    return _array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if ((index < Length) && (index >= 0))
                {
                    _array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        private int[] _array;

        public MyArrayList()
        {
            Length = 0;
            _array = new int[10];
        }

        public MyArrayList(int value)
        {
            Length = 1;
            _array = new int[10];
            _array[0] = value;
        }

        private MyArrayList(int[] array)
        {
            Length = array.Length;

            _array = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                _array[i] = array[i];
            }
        }
        public static MyArrayList Create(int[] values)
        {
            if (!(values is null))
            {
                return new MyArrayList(values);
            }

            throw new NullReferenceException("Values is null");
        }

        public void AddValueToLast(int value)
        {
            if (Length>=_array.Length)
            {
               Resize();
            }

            _array[Length] = value;

            ++Length;
        }

        public void AddValueToStart(int value)
        {
            if (Length >= _array.Length)
            {
                Resize();
            }

            for (int i = Length-1; i >= 0; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[0] = value;

            ++Length;
        }

        public void AddValueByIndex(int value, int index) 
        {
            
            if (index <= Length && index >= 0)
            {

                if (Length >= _array.Length)
                {
                Resize();
                }

                for (int i = Length-1; i >= index; i--)
                {
                    _array[i + 1] = _array[i];
                }

                _array[index] = value;

                ++Length;


            }
            else
            {
               throw new IndexOutOfRangeException();
            }

        }

        public void RemoveLastElement() 
        {
            if (!(Length == 0))
            {
                Length--;
            }

            else
            {
                throw new IndexOutOfRangeException();
            }
            Resize();
        }

        public void RemoveFirstElement()
        {

            for (int i = 1; i < Length; i++)
            {
                _array[i - 1] = _array[i];
            }

            Resize();

            if (!(Length == 0))
            {
                Length--;
            }

            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void RemoveOneElementByIndex(int index)
        {
            if (index < Length && index >= 0)
            {
                if (index == 0)
                {
                    RemoveFirstElement();
                }
                else if (index == Length - 1)
                {
                    RemoveLastElement();
                }
                else
                {
                    Length--;
                    for (int i = index; i < Length; i++)
                    {
                        _array[i] = _array[i + 1];
                    }

                    Resize();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void RemovNElementsFromLast(int nvalue)
        {
            if (nvalue < Length)
            {
                if (!(nvalue < 0))
                {
                    Length -= nvalue;
                    Resize();
                }
                else
                {
                    throw new ArgumentException("Invalid value!");
                }
            }

            else if (nvalue == Length)
            {
                Length = 0;
                _array = new int[10];
            }

            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }

        public void RemovNElementsFromStart(int nvalue)
        {
            if (nvalue < Length)
            {
                if (!(nvalue < 0))
                {
                    for (int i = nvalue; i < Length; i++)
                    {
                        _array[i - nvalue] = _array[i];
                    }

                    Length -= nvalue;
                    Resize();
                }

                else
                {
                    throw new ArgumentException("Invalid value");
                }
            }

            else if (nvalue == Length)
            {
                Length = 0;
                _array = new int[10];
            }

            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }

        public void RemoveByIndexNElements(int nvalue, int index) 
        {
            if (nvalue < Length)
            {
                if (!(nvalue < 0))
                {
                    for (int i = index + nvalue; i < Length; i++)
                    {
                        _array[i - nvalue] = _array[i];
                    }

                    Length -= nvalue;
                    Resize();
                }

                else
                {
                    throw new ArgumentException("Invalid value");
                }
            }

            else if (nvalue == Length)
            {
                Length = 0;
                _array = new int[10];
            }

            else
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }

        public int GetFirstIndexByValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (value == _array[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public void GetRevers()
        {
            int temp;
            int swapIndex;

            for (int i = 0; i < Length / 2; i++)
            {
                swapIndex = Length - i - 1;
                temp = _array[i];

                _array[i] = _array[swapIndex];

                _array[swapIndex] = temp;
            }
        }

        public int FindIndexOfMaxElem()
        {
            if (!(Length == 0))
            {

                int maxIndexOfElement = 0;

                for (int i = 1; i < Length; i++)
                {
                    if (_array[maxIndexOfElement] < _array[i])
                    {
                        maxIndexOfElement = i;
                    }
                }

                return maxIndexOfElement;
            }
            else
            {
              throw new ArgumentException();
            }
        }

        public int FindIndexOfMinElem()
        {
            if (!(Length == 0))
            {

                int minIndexOfElement = 0;

                for (int i = 1; i < Length; i++)
                {
                    if (_array[minIndexOfElement] > _array[i])
                    {
                        minIndexOfElement = i;
                    }
                }

                return minIndexOfElement;
            }
            else
            {
              throw new ArgumentException();
            }
        }

        public int FindValueOfMaxElem()
        {  
            return FindIndexOfMaxElem();
        }

        public int FindValueOfMinElem()
        {
            return FindIndexOfMinElem();
        }

        public void GetSortByAscending()
        {
            int j;
            int temp;

            for (int i = 1; i < Length; i++)
            {
                j = i;
                temp = _array[i];

                while (j > 0 && temp < _array[j - 1])
                {
                    _array[j] = _array[j - 1];
                    j--;
                }

                _array[j] = temp;
            }
        }

        public void GetDescendingSort()
        {
            int j;
            int temp;

            for (int i = 1; i < Length; i++)
            {
                j = i;
                temp = _array[i];

                while (j > 0 && temp > _array[j - 1])
                {
                    _array[j] = _array[j - 1];
                    j--;
                }

                _array[j] = temp;
            }
        }

        public void RemoveByValueOfTheFirst(int value)
        {
            int index = GetFirstIndexByValue(value);

            if (!(index == -1))
            {
                RemoveOneElementByIndex(index);
            }
        }

        public void RemoveByValueAll(int value)
        {
            int indexOfElements = GetFirstIndexByValue(value);

            while (indexOfElements != -1)
            {
                RemoveOneElementByIndex(indexOfElements);
                indexOfElements = GetFirstIndexByValue(value);
            }
        }

        public void AddListToTheEnd(MyArrayList list)
        {
            if (list != null && list.Length != 0)
            {
                int lastIndex = Length;
                AddListByIndex(list, lastIndex);
            }

            else
            {
                throw new ArgumentException("Empty list");
            }
        }

        public void AddListToStart(MyArrayList list)
        {
            if (list != null && list.Length != 0)
            {
                int firstIndex = 0;
                AddListByIndex(list, firstIndex);
            }

            else
            {
                throw new ArgumentException("Empty list");
            }
        }

        public void AddListByIndex(MyArrayList list, int index)
        {
            if (list != null && list.Length != 0)
            {
                if (index >= 0 && index <= Length)
                {
                    Length += list.Length;
                    if (Length >= _array.Length)
                    {
                        Resize();
                    }

                    int tempLength = list.Length;
                    for (int i = Length - 1; i >= index; i--)
                    {
                        if (i + tempLength < _array.Length)
                        {
                            _array[i + tempLength] = _array[i];
                        }
                    }

                    int count = 0;
                    for (int i = index; i < Length; i++)
                    {
                        if (count < list.Length)
                        {
                            _array[i] = list[count++];
                        }
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else
            {
                throw new ArgumentException("No elements in list");
            }
        }


        private void Resize()
        {
            if (Length >= _array.Length)
            {
                int newLenght = (int)(Length * 1.33 + 1);
                int[] tmpArray = new int[newLenght];

                for (int i = 0; i < _array.Length; i++)
                {
                    tmpArray[i] = _array[i];
                }

                _array = tmpArray;
            }
        }

        public override bool Equals(object obj)
        {
            MyArrayList list = (MyArrayList)obj;
            if (this.Length != list.Length)
            {

                return false;
            }

            for (int i = 0; i < Length; i++)
            {
                if (this._array[i] != list._array[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < Length; i++)
            {
                result += _array[i] + " ";

            }

            result.Trim();
            return result;
        }
    }
}
