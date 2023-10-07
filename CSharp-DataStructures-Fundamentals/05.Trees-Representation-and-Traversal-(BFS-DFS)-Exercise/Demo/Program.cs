namespace Tree
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //var input = new string[] { "9 17", "9 4", "9 14", "4 36", "14 53", "14 59", "53 67", "53 73" };
            var input = new string[] { "7 19", "7 21", "7 14", "19 1", "19 12", "19 31", "14 23", "14 6" };

            var treeFactory = new IntegerTreeFactory();

            var tree = treeFactory.CreateTreeFromStrings(input);

            Console.WriteLine("Tree as string");
            Console.WriteLine(tree.AsString());

            var leafKeys = tree.GetLeafKeys();
            Console.WriteLine($"All leaf nodes of the tree: {String.Join(" ", leafKeys)}");

            var internalKeys = tree.GetInternalKeys();
            Console.WriteLine($"Internal keys: {String.Join(" ", internalKeys)}");

            Console.WriteLine($"Deepest node: {tree.GetDeepestKey()}");

            Console.WriteLine($"Longest path to the root(the leftmost): {String.Join(" ", tree.GetLongestPath())}");
            
            var result = tree.GetPathsWithGivenSum(27);

            Console.WriteLine("Paths with given sum:");
            foreach (var path in result)
            {
                Console.WriteLine($"{String.Join(" ", path)}");
            }

            Console.WriteLine("Subtrees with given sum:");
            Console.WriteLine($"{String.Join($"{Environment.NewLine}", tree.GetSubtreesWithGivenSum(43).Select(x => String.Join(" ", x)))}");            
        }
    }
}
