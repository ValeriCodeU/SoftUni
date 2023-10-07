namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerTree : Tree<int>, IIntegerTree
    {
        public IntegerTree(int key, params Tree<int>[] children)
            : base(key, children)
        {
        }

        public IEnumerable<IEnumerable<int>> GetPathsWithGivenSum(int sum)
        {
            var result = new List<Stack<int>>();
            var leafs = new List<Tree<int>>();

            Predicate<Tree<int>> predicate = tree => tree.Children.Count == 0;

            GetResultWithDfs(this, leafs, predicate);

            foreach (var node in leafs)
            {
                int currentSum = 0;
                var currentResult = new Stack<int>();
                var currentNode = node;

                while (true)
                {
                    currentSum += currentNode.Key;
                    currentResult.Push(currentNode.Key);
                    currentNode = currentNode.Parent;

                    if (currentNode.Parent == null)
                    {
                        currentSum += currentNode.Key;
                        currentResult.Push(currentNode.Key);
                        break;
                    }
                }

                if (currentSum == sum)
                {
                    result.Add(currentResult);
                }
            }

            return result;
        }

        private void GetResultWithDfs(Tree<int> tree, List<Tree<int>> leafs, Predicate<Tree<int>> predicate)
        {
            foreach (var child in tree.Children)
            {
                if (predicate.Invoke(child))
                {
                    leafs.Add(child);
                }

                GetResultWithDfs(child, leafs, predicate);
            }
        }

        public IEnumerable<IEnumerable<int>> GetSubtreesWithGivenSum(int sum)
        {
            var result = new List<Queue<int>>();
            var internalNodes = new List<Tree<int>>();

            Predicate<Tree<int>> predicate = tree => tree.Children.Count > 0 && tree.Parent != null;

            GetResultWithDfs(this, internalNodes, predicate);

            foreach (var node in internalNodes)
            {
                var queue = new Queue<Tree<int>>();

                queue.Enqueue(node);
                int currentSum = 0;
                var currentResult = new Queue<int>();


                while (queue.Any())
                {
                    var currentNode = queue.Dequeue();
                    currentSum += currentNode.Key;
                    currentResult.Enqueue(currentNode.Key);

                    foreach (var child in currentNode.Children)
                    {
                        queue.Enqueue(child);
                    }
                }

                if (currentSum == sum)
                {
                    result.Add(currentResult);
                }
            }

            return result;
        }

    }
}
