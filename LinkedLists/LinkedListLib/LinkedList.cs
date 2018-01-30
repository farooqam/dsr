using System;
using System.Collections.Generic;

namespace LinkedListLib
{
    public class LinkedList<T> where T: IComparable<T>
    {
        public const int NotFound = -1;

        public Node<T> Head { get; set; }

        public void AddNode(T data)
        {
            if (Head == null)
            {
                Head = new Node<T> {Data = data};
                return;
            }

            var current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node<T> {Data = data};
        }

        public int Search(T data)
        {
            if (Head == null)
            {
                return NotFound;
            }

            var current = Head;
            var index = 0;

            while (current != null)
            {
                if (current.Data.CompareTo(data) == 0)
                {
                    return index;
                }

                index++;
                current = current.Next;
            }

            return NotFound;
        }

        public Node<T> ItemAt(int index)
        {
            if (Head == null)
            {
                return null;
            }

            var currentIndex = 0;
            var current = Head;

            while (currentIndex != index)
            {
                if (current.Next == null)
                {
                    return current;
                }

                currentIndex++;
                current = current.Next;
            }

            return current;
        }

        public void InsertAt(int index, T data)
        {
            if (Head == null)
            {
                AddNode(data);
            }

            var current = Head;
            var currentIndex = 0;

            while (currentIndex < index)
            {
                if (current.Next == null)
                {
                    break;
                }

                currentIndex++;
                current = current.Next;
            }

            var newNode = new Node<T>() {Data = data, Next = current.Next};
            current.Next = newNode;
        }

        public IEnumerable<T> EnumerateNodes()
        {
            var current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}