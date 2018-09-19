using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Practice.DataSets.Implementations.Trees;

namespace Practice.DataSets.Implementations.Trees
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode() : base() { }
        public BinaryTreeNode(T data) : base(data, null) { }
        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            base.Value = data;
            var children = new NodeList<T>(2);
            children[0] = left;
            children[1] = right;
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (base.Neighbours == null)
                {
                    return null;
                }
                else
                {
                    return (BinaryTreeNode<T>) base.Neighbours[0];
                }
            }

            set
            {
                if (base.Neighbours == null)
                {
                    base.Neighbours = new NodeList<T>(2);
                }

                base.Neighbours[0] = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                if (base.Neighbours == null)
                {
                    return null;
                }
                else
                {
                    return (BinaryTreeNode<T>) base.Neighbours[1];
                }
            }
            set
            {
                if (base.Neighbours == null)
                {
                    base.Neighbours = new NodeList<T>(2);
                }

                base.Neighbours[1] = value;
            }
        }

    }
}
