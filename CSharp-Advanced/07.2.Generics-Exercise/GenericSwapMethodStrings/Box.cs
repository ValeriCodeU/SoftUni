using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        private List<T> boxList = new List<T>();

        public void Add(T box)
        {
            boxList.Add(box);
        }

        public void Swap(int index1, int index2)
        {
            T temp = boxList[index1];
            boxList[index1] = boxList[index2];
            boxList[index2] = temp;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

           
            foreach (var item in boxList)
            {
                Type type = item.GetType();

                builder.AppendLine($"{type}: {item}");
            }

            return builder.ToString().TrimEnd();
        }

    }
}
