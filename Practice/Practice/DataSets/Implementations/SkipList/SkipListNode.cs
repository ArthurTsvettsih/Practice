using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.DataSets.Implementations.Trees;

namespace Practice.DataSets.Implementations.SkipList
{
    public class SkipListNode<T> : Node<T>
    {
        public int Height => base.Neighbours.Count;
        public SkipListNode(int height)
        {
            base.Neighbours = new NodeList<T>(height);
        }

        public SkipListNode(T value, int height) : base(value)
        {
            base.Neighbours = new SkipListNodeList<T>(height);
        }

        public SkipListNode<T> this[int index]
        {
            get { return (SkipListNode<T>)base.Neighbours[index]; }
            set { base.Neighbours[index] = value; }
        }

        internal void IncrementHeight()
        {
            // Insert dummy head
            base.Neighbours.Add(default(Node<T>));
        }

        internal void DecrementHeight()
        {
            base.Neighbours.RemoveAt(base.Neighbours.Count - 1);
        }
    }
}
