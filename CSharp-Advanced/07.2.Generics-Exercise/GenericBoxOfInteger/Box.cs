using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private List<T> boxList = new List<T>();
        
        public void Add(T box)
        {
            boxList.Add(box);
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
