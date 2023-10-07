namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Tree<T> : IAbstractTree<T>
    {
        private List<Tree<T>> children;

        public Tree(T key, params Tree<T>[] children)
        {
            this.children = new List<Tree<T>>();
            Key = key;

            foreach (var child in children)
            {
                child.Parent = this;
                AddChild(child);
            }
        }

        public T Key { get; private set; }

        public Tree<T> Parent { get; private set; }

        public IReadOnlyCollection<Tree<T>> Children => children.AsReadOnly();

        public void AddChild(Tree<T> child)
        {
            children.Add(child);
        }

        public void AddParent(Tree<T> parent)
        {
            Parent = parent;
        }

        public string AsString()
        {
            var sb = new StringBuilder();

            DfsAsString(this, sb, 0);

            return sb.ToString().TrimEnd();
        }

        private void DfsAsString(Tree<T> tree, StringBuilder sb, int indent)
        {
            sb.Append(' ', indent)
                .AppendLine(tree.Key.ToString());

            foreach (var child in tree.children)
            {
                DfsAsString(child, sb, indent + 2);
            }

        }

        public IEnumerable<T> GetInternalKeys()
        {
            var result = new List<Tree<T>>();

            Predicate<Tree<T>> predicate = tree => tree.children.Count > 0 && tree.Parent != null;

            GetResultWithDfs(this, result, predicate);


            return result.Select(tree => tree.Key);

        }

        public IEnumerable<T> GetLeafKeys()
        {
            var result = new List<Tree<T>>();

            Predicate<Tree<T>> predicate = tree => tree.children.Count == 0;

            GetResultWithDfs(this, result, predicate);


            return result.Select(tree => tree.Key);
        }

        private void GetResultWithDfs(Tree<T> tree, List<Tree<T>> result, Predicate<Tree<T>> predicate)
        {

            foreach (var child in tree.children)
            {
                if (predicate.Invoke(child))
                {
                    result.Add(child);                    
                }

                GetResultWithDfs(child, result, predicate);
            }
        }

        public T GetDeepestKey()
        {
            return GetDeepestNode().Key;
        }

        public Tree<T> GetDeepestNode()
        {
            var leafs = new List<Tree<T>>();

            Predicate<Tree<T>> predicate = tree => tree.children.Count == 0;

            GetResultWithDfs(this, leafs, predicate);

            Tree<T> deepestNod = null;
            var maxDepth = 0;

            foreach (var leaf in leafs)
            {
                var currentNode = leaf;
                int depth = 0;

                while (currentNode.Parent != null)
                {
                    currentNode = currentNode.Parent;
                    depth++;
                }

                if (depth > maxDepth)
                {
                    maxDepth = depth;
                    deepestNod = leaf;
                }
            }
            return deepestNod;
        }

        public IEnumerable<T> GetLongestPath()
        {
            var result = new Stack<T>();

            var deepestNode = GetDeepestNode();

            while (deepestNode.Parent != null)
            {
                result.Push(deepestNode.Key);
                deepestNode = deepestNode.Parent;
            }

            result.Push(Key);

            return result;

        }
    }
}
