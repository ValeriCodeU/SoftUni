using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> boxList = new List<T>();

        public int Count => boxList.Count;

        public void Add (T element)
        {
            boxList.Add(element);
        }

        public T Remove()
        {
            var element = boxList[boxList.Count - 1];
            boxList.Remove(element);
            return element;
        }
    }
}
