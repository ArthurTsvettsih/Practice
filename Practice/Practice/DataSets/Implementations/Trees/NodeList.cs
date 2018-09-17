using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataSets.Implementations.Trees
{
    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() : base() { }

        public NodeList(int initialSize)
        {
            for (int i = 0; i < initialSize; i++)
            {
                base.Items.Add(default(Node<T>));
            }
        }

        public Node<T> FindByValue(T value)
        {
            foreach (var node in Items)
            {
                if (node.Value.Equals(value))
                {
                    return node;
                }
            }

            return null;
        }
    }
}
