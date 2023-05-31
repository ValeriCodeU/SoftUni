namespace Problem01.CircularQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CircularQueue<T> : IAbstractQueue<T>
    {
        private T[] elements;
        private int startIndex;
        private int endIndex;

        public CircularQueue(int capacity = 4)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; set; }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var result = this.elements[startIndex];
            this.startIndex = (startIndex + 1) % this.elements.Length;
            this.Count--;

            return result;
        }

        private void Grow()
        {
            this.elements = this.CopyElements(new T[this.elements.Length * 2]);
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        private T[] CopyElements(T[] resultArray)
        {
            int sourceIndex = this.startIndex;

            for (int i = 0; i < this.Count; i++)
            {
                resultArray[i] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
            }

            return resultArray;
        }

        public void Enqueue(T item)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }

            this.elements[endIndex] = item;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;

        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            return this.elements[startIndex];
        }

        public T[] ToArray()
        {
            return this.CopyElements(new T[this.Count]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.elements[(this.startIndex + i) % this.elements.Length];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
