﻿namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerTreeFactory
    {
        private Dictionary<int, IntegerTree> nodesByKey;

        public IntegerTreeFactory()
        {
            this.nodesByKey = new Dictionary<int, IntegerTree>();
        }

        public IntegerTree CreateTreeFromStrings(string[] input)
        {
            foreach (var item in input)
            {
                var keys = item.Split(' ').Select(int.Parse).ToArray();
                var parent = keys[0];
                var child = keys[1];

                this.AddEdge(parent, child);
            }

            return this.GetRoot();
        }

        public IntegerTree CreateNodeByKey(int key)
        {
            if (!nodesByKey.ContainsKey(key))
            {
                this.nodesByKey.Add(key, new IntegerTree(key));
            }

            return this.nodesByKey[key];
        }

        public void AddEdge(int parent, int child)
        {
            var parentNode = this.CreateNodeByKey(parent);
            var childeNode = this.CreateNodeByKey(child);

            parentNode.AddChild(childeNode);
            childeNode.AddParent(parentNode);
        }

        public IntegerTree GetRoot()
        {
            foreach (var kvp in nodesByKey)
            {
                if (kvp.Value.Parent == null)
                {
                    return kvp.Value;
                }
            }

            return null;
        }
    }
}
