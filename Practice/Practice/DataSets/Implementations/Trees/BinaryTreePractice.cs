using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataSets.Implementations.Trees
{
    public class BinaryTreePractice
    {
        //TODO: add methods to use the BinaryTree class and add a menu to the console
        private BinaryTree<int> _binaryTree { get; set; }

        public void CreateTree()
        {
            _binaryTree = new BinaryTree<int>();
            _binaryTree.Root = new BinaryTreeNode<int>(7);
            _binaryTree.Root.Left = new BinaryTreeNode<int>(3);
            _binaryTree.Root.Right = new BinaryTreeNode<int>(11);

            _binaryTree.Root.Left.Left = new BinaryTreeNode<int>(1);
            _binaryTree.Root.Left.Right = new BinaryTreeNode<int>(5);
            _binaryTree.Root.Left.Right.Left = new BinaryTreeNode<int>(4);

            _binaryTree.Root.Right.Left = new BinaryTreeNode<int>(10);
            _binaryTree.Root.Right.Right = new BinaryTreeNode<int>(15);
        }


      
    }
}
