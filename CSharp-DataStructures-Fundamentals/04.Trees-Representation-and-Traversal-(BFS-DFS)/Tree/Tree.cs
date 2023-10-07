namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tree<T> : IAbstractTree<T>
    {
        private T value;
        private List<Tree<T>> children;
        private Tree<T> parent;

        public Tree()
        {

        }

        public Tree(T _value)
        {
            value = _value;
            children = new List<Tree<T>>();
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (var child in children)
            {
                child.parent = this;
                this.children.Add(child);
            }
        }

        public void AddChild(T parentKey, Tree<T> child)
        {
            var parentNode = FindNodeWithBfs(parentKey);

            if (parentNode != null)
            {
                parentNode.children.Add(child);
                child.parent = parentNode;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public IEnumerable<T> OrderBfs()
        {
            var queue = new Queue<Tree<T>>();
            queue.Enqueue(this);

            var result = new List<T>();

            while (queue.Any())
            {
                var node = queue.Dequeue();
                result.Add(node.value);

                foreach (var child in node.children)
                {
                    queue.Enqueue(child);
                }
            }

            return result;
        }

        public IEnumerable<T> OrderDfs()
        {
            var result = new List<T>();
            this.DfsWithRecursion(this, result);

            //result = this.DfsWithStack().ToList();

            return result;
        }

        public void RemoveNode(T nodeKey)
        {
            var toBeDeletedNode = FindNodeWithBfs(nodeKey);

            if (toBeDeletedNode == null)
            {
                throw new ArgumentNullException();
            }

            var parentNode = toBeDeletedNode.parent;

            if (parentNode == null)
            {
                throw new ArgumentException();
            }

            parentNode.children.Remove(toBeDeletedNode);
        }

        public void Swap(T firstKey, T secondKey)
        {
            var firstNode = FindNodeWithDfs(firstKey);
            var secondNode = FindNodeWithDfs(secondKey);

            if (firstNode == null || secondNode == null)
            {
                throw new ArgumentNullException();
            }

            var firstParentNode = firstNode.parent;
            var secondParentNode = secondNode.parent;

            if (firstParentNode == null || secondParentNode == null)
            {
                throw new ArgumentException();
            }

            var indexOfFirstChild = firstParentNode.children.IndexOf(firstNode);
            var indexOfSecondChild = secondParentNode.children.IndexOf(secondNode);

            firstParentNode.children[indexOfFirstChild] = secondNode;
            secondNode.parent = firstParentNode;

            secondParentNode.children[indexOfSecondChild] = firstNode;
            firstNode.parent = secondParentNode;
        }

        private Tree<T> FindNodeWithBfs(T nodeKey)
        {
            var queue = new Queue<Tree<T>>();
            queue.Enqueue(this);

            while (queue.Any())
            {
                var node = queue.Dequeue();

                if (node.value.Equals(nodeKey))
                {
                    return node;
                }

                foreach (var child in node.children)
                {
                    queue.Enqueue(child);
                }
            }

            return null;
        }

        //private Tree<T> FindNodeWithDfs(T nodeKey)
        //{
        //    var result = new Tree<T>();

        //    this.Dfs(nodeKey, result, this);

        //    return result;
        //}

        private Tree<T> FindNodeWithDfs(T nodeKey)
        {
            if (this.value.Equals(nodeKey))
            {
                return this;
            }

            foreach (var child in children)
            {
                var result = child.FindNodeWithDfs(nodeKey);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }

        private IEnumerable<T> DfsWithStack()
        {
            var result = new Stack<T>();

            var stack = new Stack<Tree<T>>();

            stack.Push(this);

            while (stack.Any())
            {
                var node = stack.Pop();
                foreach (var child in node.children)
                {
                    stack.Push(child);
                }

                result.Push(node.value);
            }

            return result;

        }

        private void DfsWithRecursion(Tree<T> tree, List<T> result)
        {
            foreach (var child in tree.children)
            {
                this.DfsWithRecursion(child, result);
            }

            result.Add(tree.value);
        }

        //private void Dfs(T nodeKey, Tree<T> result, Tree<T> tree)
        //{
        //    foreach (var child in tree.children)
        //    {
        //        if (child.value.Equals(nodeKey))
        //        {
        //            result = child;
        //            return;
        //        }

        //        this.Dfs(nodeKey, result, child);
        //    }           
        //}
    }
}
