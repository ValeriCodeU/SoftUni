namespace Problem03.Queue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Queue<T> : IAbstractQueue<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node Next { get; set; }

            public Node(T element, Node next)
            {
                this.Element = element;
                this.Next = next;
            }

            public Node(T element)
            {
                this.Element = element;
            }
        }

        private Node head;       

        public int Count { get; private set; }

        public void Enqueue(T item)
        {
            var newNode = new Node(item);

            if (this.head == null)
            {
                this.head = newNode;                
            }

            else
            {
                var currentnode = this.head;

                while (currentnode.Next != null)
                {
                    currentnode = currentnode.Next;
                }

                currentnode.Next = newNode;

            }            

            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Invalid operation");
            }

            this.Count--;
            var nodeElement = this.head.Element;
            this.head = this.head.Next;

            return nodeElement;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Invalid operation");
            }

            return this.head.Element;
        }

        public bool Contains(T item)
        {
            if (this.Count > 0)
            {
                var currentNode = this.head;

                while (currentNode != null)
                {
                    if (currentNode.Element.Equals(item))
                    {
                        return true;
                    }
                    currentNode = currentNode.Next;
                }
            }

            return false;
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;

            while (currentNode != null)
            {
                yield return currentNode.Element;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}