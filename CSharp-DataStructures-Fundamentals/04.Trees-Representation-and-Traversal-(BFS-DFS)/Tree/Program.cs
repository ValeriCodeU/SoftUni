namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {

            //var tree = new Tree<int>(34, new Tree<int>(33));

            //var tree = new Tree<int>(7,
            //           new Tree<int>(19,
            //                   new Tree<int>(1),
            //                   new Tree<int>(12),
            //                   new Tree<int>(31)),
            //           new Tree<int>(21),
            //           new Tree<int>(14,
            //                   new Tree<int>(23),
            //                   new Tree<int>(6)));

            //tree.AddChild(19, new Tree<int>(40));
            //tree.RemoveNode(19);

            //лектор

            var tree = new Tree<int>(34,
                
                new Tree<int>(36, 
                        new Tree<int>(42), 
                        new Tree<int>(3, 
                                new Tree<int>(78))), 
                new Tree<int>(1, 
                        new Tree<int>(6)), 
                new Tree<int>(103));


            Console.WriteLine(String.Join(", ", tree.OrderBfs()));
            Console.WriteLine(String.Join(", ", tree.OrderDfs()));
            tree.Swap(36, 42);
            Console.WriteLine(String.Join(", ", tree.OrderDfs()));

        }
    }
}
