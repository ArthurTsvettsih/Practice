using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.DataSets.Implementations.Trees;

namespace Practice.DataSets.Implementations.Graphs
{
    public class GraphNode<T> : Node<T>
    {
        private List<int> costs;

        new public NodeList<T> Neighbours => base.Neighbours == null ? new NodeList<T>() : base.Neighbours;

        public List<int> Costs => costs == null ? new List<int>() : costs;

        public GraphNode() : base() { }

        public GraphNode(T value) : base(value) { }

        public GraphNode(T value, NodeList<T> neighbours) : base(value, neighbours) { }

    }
}
