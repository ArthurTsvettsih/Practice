using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.DataSets.Implementations.Trees;

namespace Practice.DataSets.Implementations.Graphs
{
    public class Graph<T> : IEnumerable<T>
    {
        private NodeList<T> _nodeSet;

        public NodeList<T> Nodes => _nodeSet;

        public int Count => _nodeSet.Count;

        public Graph() : this(null) { }
        public Graph(NodeList<T> nodeSet)
        {
            _nodeSet = nodeSet ?? new NodeList<T>();
        }

        public void AddNode(GraphNode<T> node)
        {
            _nodeSet.Add(node);
        }

        public void AddNode(T value)
        {
            _nodeSet.Add(new GraphNode<T>(value));
        }

        public void AddDirectedEdge(T from,T to)
        {
            AddDirectedEdge(new GraphNode<T>(from), new GraphNode<T>(to));
        }

        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to)
        {
            AddDirectedEdge(from, to, 0);
        }

        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbours.Add(to);
            from.Costs.Add(cost);
        }

        public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbours.Add(to);
            from.Costs.Add(cost);

            to.Neighbours.Add(from);
            to.Costs.Add(cost);
        }

        public bool Contains(T value)
        {
            return _nodeSet.FindByValue(value) != null;
        }

        public bool Remove(T value)
        {
            GraphNode<T> nodeToRemove = (GraphNode<T>) _nodeSet.FindByValue(value);

            if (nodeToRemove == null)
            {
                return false;
            }

            _nodeSet.Remove(nodeToRemove);

            foreach (GraphNode<T> node in _nodeSet)
            {
                int index = node.Neighbours.IndexOf(nodeToRemove);

                if (index != -1)
                {
                    node.Neighbours.RemoveAt(index);
                    node.Costs.RemoveAt(index);
                }
            }

            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
