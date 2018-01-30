using System;

namespace LinkedListLib
{
    public class Node<T> where T: IComparable<T>
    {
        public T Data { get; set; }

        public Node<T> Next { get; set; }
    }
}