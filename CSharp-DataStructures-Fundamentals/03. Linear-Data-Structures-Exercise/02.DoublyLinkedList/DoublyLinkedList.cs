namespace Problem02.DoublyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IAbstractLinkedList<T>
    {
        private class Node
        {
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public T Element { get; set; }

            public Node(T element)
            {
                this.Element = element;
            }
        }

        private Node head;
        private Node tail;

        public int Count { get; set; }

        public void AddFirst(T item)
        {
            var newNode = new Node(item);

            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.Next = this.head;
                this.head.Previous = newNode;
                this.head = newNode;
            }

            this.Count++;
        }

        public void AddLast(T item)
        {
            var newNode = new Node(item);

            if (this.Count == 0)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.Previous = this.tail;
                this.tail.Next = newNode;
                this.tail = newNode;
            }

            this.Count++;
           
        }

        public T GetFirst()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }

            return this.head.Element;
        }

        public T GetLast()
        {
            if (this.tail == null)
            {
                throw new InvalidOperationException();
            }

            return this.tail.Element;
        }

        public T RemoveFirst()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }

            var resultElement = this.head.Element;

            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                this.head = this.head.Next;
                this.head.Previous = null;
            }
            
            this.Count--;

            return resultElement;
        }

        public T RemoveLast()
        {
            if (this.tail == null)
            {
                throw new InvalidOperationException();
            }

            var resultElement = this.tail.Element;

            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                this.tail = this.tail.Previous;
                this.tail.Next = null;
            }

            this.Count--;

            return resultElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.head;

            while (node != null)
            {
                yield return node.Element;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}