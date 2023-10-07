namespace _03.MaxHeap
{
    using System;
    using System.Collections.Generic;

    public class MaxHeap<T> : IAbstractHeap<T> where T : IComparable<T>
    {
        private List<T> elements;
        public const int FirstIndex = 0;

        public MaxHeap()
        {
            this.elements = new List<T>();
        }

        public int Size => this.elements.Count;
        public int LastIndex => this.elements.Count - 1;
        

        public void Add(T element)
        {
            this.elements.Add(element);
            this.HeapifyUp(this.LastIndex);
        }

        private void HeapifyUp(int index)
        {
            var parentIndex = (index - 1) / 2;

            while (index > 0 && IsGreater(index, parentIndex))
            {
                this.Swap(parentIndex, index);
                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
        }

        private void Swap(int parentIndex, int index)
        {
            var temp = this.elements[index];
            this.elements[index] = this.elements[parentIndex];
            this.elements[parentIndex] = temp;
        }

        private bool IsGreater(int index, int parentIndex)
        {
            return this.elements[index].CompareTo(this.elements[parentIndex]) > 0;
        }

        public T ExtractMax()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException();
            }

            T element = this.elements[FirstIndex];
            this.Swap(FirstIndex, this.LastIndex);
            this.elements.RemoveAt(this.LastIndex);
            this.HeapifyDown(FirstIndex);

            return element;
        }

        private void HeapifyDown(int index)
        {
            var biggerChildIndex = this.GetBiggerChildIndex(index);
            while (biggerChildIndex >= 0 && IsGreater(biggerChildIndex, index))
            {
                this.Swap(biggerChildIndex, index);
                index = biggerChildIndex;
                biggerChildIndex = this.GetBiggerChildIndex(index);
            }
        }

        private int GetBiggerChildIndex(int index)
        {
            var firstChildIndex = index * 2 + 1;
            var secondChildIndex = index * 2 + 2;

            if (secondChildIndex < this.elements.Count)
            {
                if (this.IsGreater(firstChildIndex, secondChildIndex))
                {
                    return firstChildIndex;
                }

                return secondChildIndex;
            }
            else if (firstChildIndex < this.elements.Count)
            {
                return firstChildIndex;
            }
            else
            {
                return -1;
            }
        }

        public T Peek()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException();
            }            

            return this.elements[0];
        }
    }
}
