using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practice.DataSets.Implementations.Trees
{
    public class Node<T>
    {
        protected NodeList<T> Children { get; set; }

        public T Value
        {
            get => data;
            set => data = value;
        }

        private T data;
        private NodeList<T> children = null;

        public Node() { }

        public Node(T data) : this(data, null) { }

        public Node(T data, NodeList<T> children)
        {
            this.data = data;
            this.children = children;
        }

    }
}
