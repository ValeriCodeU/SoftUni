using System;
using System.Diagnostics.CodeAnalysis;
using _02.BinarySearchTree;
using _03.MaxHeap;
using _01.BinaryTree;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>(1, new BinaryTree<int>(2, null, null),
                new BinaryTree<int>(3, new BinaryTree<int>(4, null, null), new BinaryTree<int>(5, null, null)));

            Console.WriteLine(tree.AsIndentedPreOrder(0));

            var resultPreOrder = tree.PreOrder();
            var resultPostOrder = tree.PostOrder();
            var resultInOrder = tree.InOrder();

            var heap = new MaxHeap<int>();

            //heap.Add(1);
            //heap.Add(2);
            //heap.Add(3);
            //heap.Add(4);

            heap.Add(5);
            heap.Add(3);
            heap.Add(1);

            heap.ExtractMax();
            heap.ExtractMax();
            heap.ExtractMax();

            Console.WriteLine(heap.Size);

        }
    }
}