namespace Problem01.List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class List<T> : IAbstractList<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] items;

        public List()
            : this(DEFAULT_CAPACITY)
        {
        }

        public List(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            this.items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return items[index];
            }

            set
            {
                ValidateIndex(index);
                this.items[index] = value;
            }

        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (this.Count == this.items.Length)
            {
                this.Grow();
            }
            this.items[Count] = item;
            this.Count++;
        }


        public bool Contains(T item)
        {

            return this.IndexOf(item) != -1 ? true : false;

            //if (this.items.Take(this.Count).Contains(item))
            //{
            //    return true;
            //}

            //return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            this.ValidateIndex(index);

            if (this.Count == this.items.Length)
            {
                this.Grow();
            }

            //for (int i = this.Count; i > index; i--)
            //{
            //    this.items[i] = this.items[i - 1];
            //}
            
            //3, 5, 7, 1, -5, -100

            var currentElement = this.items[index]; //5
            this.items[index] = item; // 2
            this.Count++;

            T temp = default;

            for (int i = index + 1; i < this.Count; i++)
            {
                temp = this.items[i];
                this.items[i] = currentElement;
                currentElement = temp;
            }

            //this.items[index] = item;
            
        }


        public bool Remove(T item)
        {
            var index = this.IndexOf(item);

            if (index != -1)
            {
                this.RemoveAt(index);

                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            this.ValidateIndex(index);

            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.items[Count - 1] = default;
            this.Count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void Grow()
        {
            var newArray = new T[this.items.Length * 2];

            Array.Copy(this.items, newArray, this.Count);

            this.items = newArray;

        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
        }
    }
}