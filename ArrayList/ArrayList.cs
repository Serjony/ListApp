using System;

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

        //private const int indexZero = 0;

        //private const int shiftOne = 1;

        public MyArrayList()
        {
            Length = 0;
            _array = new int[10];
        }

        public MyArrayList(int value)
        {
            Length = 0;
            _array = new int[10];
            _array[0] = value;
        }

        public MyArrayList(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            Length = array.Length;
            _array = array;

            Resize();
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

            Resize();
        }

        public void RemoveFirstElement()
        {

            for (int i = 1; i <= Length; i++)
            {
                _array[i-1] = _array[i];
            }

            if (!(Length == 0))
            {
                Length--;
            }

            Resize();
        }

        public void RemoveOneElementByIndex(int index)
        {
            if (index < Length && index >= 0)
            {

                for (int i = index; i < Length; i++)
                {
                    _array[i] = _array[i+1];
                }

                Length--;

                Resize();
            }
           
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void RemovNElementsFromLast(int Nvalue)
        {
            if (Nvalue < Length && Nvalue >= 0)
            {
                Length -= Nvalue;

                Resize();
            }
        }

        public void RemovNElementsFromStart(int Nvalue)
        {
            if (Nvalue < Length && Nvalue >= 0)
            {

                for (int i = Nvalue; i <= Length; i++)
                {
                    _array[i-Nvalue] = _array[i];
                }

                Length -= Nvalue;
                Resize();
            }
        }

        public void RemoveByIndexNElements(int Nvalue, int Index) 
        {
            if (Index < Length && Index >= 0 && Length-Nvalue>0)
            {

                for (int i = Index + Nvalue; i <= Length; i++)
                {
                    _array[i - Nvalue] = _array[i];
                }

                Length -= Nvalue;
                Resize();

            }
            else
            {
              throw new IndexOutOfRangeException();
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

        public void AddListToTheEnd()
        {

        }

        public void AddListToStart()
        {

        }

        public void AddListByIndex()
        {

        }


        private void Resize()
        {
            if (Length >= _array.Length)
            {
                int newLenght = (int)(Length * 1.33 + 1);
                int[] tmpArray = new int[newLenght];

                for (int i = 0; i < Length; i++)
                {
                    tmpArray[i] = _array[i];
                }

                _array = tmpArray;
            }
        }

        //private void ShiftRight(int index, int nElements)
        //{
        //    for (int i = Length - 1; i > index; --i)
        //    {
        //        _array[i] = _array[i - nElements];
        //    }

        //}
        
        //private void ShiftLeft(int index, int nElements)
        //{
        //    for (int i = index; i < Length; ++i)
        //    {
        //        _array[i] = _array[i + nElements];
        //    }
        //}

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
