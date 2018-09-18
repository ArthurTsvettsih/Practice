using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice.DataSets.Implementations.Trees
{
    //TODO: Either repeat repetition or make it more obvious that you are using different traversal methods
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;
        private Comparer<T> _comparer { get; set; }
        private int _count { get; set; }

        public BinaryTreeNode<T> Root
        {
            get => root;
            set => root = value;
        }

        void PreorderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                Console.WriteLine(current.Value);
                PreorderTraversal(current.Left);
                PreorderTraversal(current.Right);
            }
        }

        void InorderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                InorderTraversal(current.Left);
                Console.WriteLine(current.Value);
                InorderTraversal(current.Right);
            }
        }

        void PostorderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                PostorderTraversal(current.Left);
                PostorderTraversal(current.Right);
                Console.WriteLine(current.Value);
            }
        }

        public BinaryTree()
        {
            root = null;
        }

        public virtual void Clear()
        {
            root = null;
        }

        public bool Contains(T data)
        {
            var current = root;

            int result;

            while (current != null)
            {
                result = _comparer.Compare(current.Value, data);

                if (result == 0)
                {
                    return true;
                }
                else if (result > 0)
                {
                    current = current.Left;
                }
                else if (result < 0)
                {
                    current = current.Right;
                }
            }

            return false;
        }

        public virtual void Add(T data)
        {
            var newNode = new BinaryTreeNode<T>(data);
            int result;

            var current = root;
            BinaryTreeNode<T> parent = null;

            while (current != null)
            {
                result = _comparer.Compare(current.Value, data);
                if (result == 0)
                {
                    //This node already exists - do nothing
                    return;
                }
                else if (result > 0)
                {
                    // Must add newNode to current's left subtree
                    parent = current;
                    current = current.Left;
                }
                else if (result > 0)
                {
                    // Must add newNode to current's right subtree
                    parent = current;
                    current = current.Right;
                }
            }

            _count++;

            // New tree
            if (parent == null)
            {
                root = newNode;
            }
            else
            {
                result = _comparer.Compare(parent.Value, data);

                if (result > 0)
                {
                    parent.Left = newNode;
                }
                else
                {
                    parent.Right = newNode;
                }
            }
        }

        public virtual bool Remove(T data)
        {
            // Tree is empty
            if (root == null)
            {
                return false;
            }

            var current = root;
            BinaryTreeNode<T> parent = null;

            int result = _comparer.Compare(current.Value, data);
            while (result != 0)
            {
                if (result > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }

                if (current == null)
                {
                    return false;
                }
                else
                {
                    result = _comparer.Compare(current.Value, data);
                }
            }

            _count--;

            if (current.Right == null)
            {
                if (parent == null)
                {
                    root = current.Left;
                }
                else
                {
                    result = _comparer.Compare(parent.Value, current.Value);
                    if (result > 0)
                    {
                        parent.Left = current.Left;
                    }
                    else if (result < 0)
                    {
                        parent.Right = current.Left;
                    }
                }
            }
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (parent == null)
                {
                    root = current.Right;
                }
                else
                {
                    result = _comparer.Compare(parent.Value, current.Value);
                    if (result > 0)
                    {
                        parent.Left = current.Right;
                    }
                    else if (result < 0)
                    {
                        parent.Right = current.Right;
                    }
                }
            }
            else
            {
                var leftMost = current.Right.Left;
                var leftMostParent = current.Right;

                while (leftMost.Left != null)
                {
                    leftMostParent = leftMost;
                    leftMost = leftMost.Left;
                }

                leftMostParent.Left = leftMost.Right;

                leftMost.Left = current.Left;
                leftMost.Right = current.Right;

                if (parent == null)
                {
                    root = leftMost;
                }
                else
                {
                    result = _comparer.Compare(parent.Value, current.Value);
                    if (result > 0)
                    {
                        // parent.Value > current.Value, so make leftmost a left child of parent
                        parent.Left = leftMost;
                    }
                    else if (result < 0)
                    {
                        // parent.Value < current.Value, so make leftmost a right child of parent
                        parent.Right = leftMost;
                    }
                }
            }

            return true;
        }

    }
}
