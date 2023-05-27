namespace Problem04.SinglyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList<T> : IAbstractLinkedList<T>
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

        public int Count { get; set; }

        public void AddFirst(T item)
        {
            var newNode = new Node(item, this.head);
            this.head = newNode;
            this.Count++;
        }

        public void AddLast(T item)
        {
            var newNode = new Node(item);

            if (this.Count == 0)
            {
                this.head = newNode;
            }

            else
            {
                var currentNode = this.head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }

            this.Count++;
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

        public T GetFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            return this.head.Element;
        }

        public T GetLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var currentNode = this.head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Element;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var firstNode = this.head;
            this.head = firstNode.Next;
            this.Count--;

            return firstNode.Element;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {                
                throw new InvalidOperationException();
            }

            var currentNode = this.head;
            T result = default;
            var count = this.Count - 1;            

            if (this.Count == 1)
            {
                result = currentNode.Element;
                currentNode = null;                
            }
            else
            {               

                while (count > 0)
                {
                    count--;

                    if (count == 0)
                    {
                        result = currentNode.Next.Element;
                        currentNode.Next = null;
                    }

                    currentNode = currentNode.Next;
                }
            }

            this.Count--;

            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}