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
        public int Height => base.Children.Count;
        public SkipListNode(int height)
        {
            base.Children = new NodeList<T>(height);
        }

        public SkipListNode(T value, int height) : base(value)
        {
            base.Children = new SkipListNodeList<T>(height);
        }

        public SkipListNode<T> this[int index]
        {
            get { return (SkipListNode<T>)base.Children[index]; }
            set { base.Children[index] = value; }
        }

        internal void IncrementHeight()
        {
            // Insert dummy head
            base.Children.Add(default(Node<T>));
        }

        internal void DecrementHeight()
        {
            base.Children.RemoveAt(base.Children.Count - 1);
        }
    }
}
