using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    class DoubleLinkedList
    {
        //public void GetSortByAscending()
        //{
        //    public static Node SortLinkedList(Node head, int count)
        //    {
                

        //        Node _current = head;
        //        Node _previous = _current;

        //        Node _min = _current;
        //        Node _minPrevious = _min;

        //        Node _sortedListHead = null;
        //        Node _sortedListTail = _sortedListHead;

        //        for (int i = 0; i < count; i++)
        //        {
        //            _current = head;
        //            _min = _current;
        //            _minPrevious = _min;

                    
        //            while (_current != null)
        //            {
        //                if (_current.Data < _min.Data)
        //                {
        //                    _min = _current;
        //                    _minPrevious = _previous;
        //                }
        //                _previous = _current;
        //                _current = _current.Next;
        //            }

                    
        //            if (_min == head)
        //            {
        //                head = head.Next;
        //            }
        //            else if (_min.Next == null) 
        //            {
        //                _minPrevious.Next = null;
        //            }
        //            else
        //            {
        //                _minPrevious.Next = _minPrevious.Next.Next;
        //            }


                    
        //            if (_sortedListHead != null)
        //            {
        //                _sortedListTail.Next = _min;
        //                _sortedListTail = _sortedListTail.Next;
        //            }
        //            else
        //            {
        //                _sortedListHead = _min;
        //                _sortedListTail = _sortedListHead;
        //            }
        //        }

        //        return _sortedListHead;
        //    }
        //}
    }
}
