## Trees
- Not part of .NET Framework Base Class library
- Stores data in a non-linear fashion
- A Tree is a colleciton of nodes
- There is only 1 root node, ie a node without a parent
- Every non-root node has 1 parent
- Nodes that have no children are called "leaf nodes"
- Nodes that have one or two children are referred to as "internal nodes"
- Children nodes are also known as neighbours
- There are no cycles 
- Trees are useful for arranging data in a hierarchy
- Not stored contagiuously in memory

## Binary Tree
- Special kind of tree where each node has at most 1 child - left child and right child
- Offers no benefits over an array unless it is sorted
- Generally does not allow duplicates as that ruins the tree

## Binary Search Tree aka BST
- For any node n, every descendant node's value in the left subtree of n is less than the value of n, and every descendant node's value in the right subtree is greater than the value of n. Meaning that n.Left < n && n.Right > n
- In order to uphold this role, we need to be able to compare the tree's data type
- Can search the tree in O(log n), however this depends on the trees topology, ie how the tree is laid out
- Insert also takes O(log n) as we need to find where to inster the new leaf node
- Insertion determines the tree's breadth, which directly impacts how efficient it is. For example, if we insert 1,2,3,4,5,6 our tree will be basically an array, however if we insert 4,2,5,1,3,6 our tree will be balanced. There are self balancing trees that deal with this issue
- When deleting a node, we must be careful not to break the tree's topology:
    - If the node being deleted has no right child, then the node's left child can be used as the replacement
    - If the deleted node's right child has no left child, then the deleted node's right child can replace the deleted node
    - If the deleted node's right child does have a left child, then the deleted node needs to be replaced by the deleted node's right child's left-most descendant
- In order to accomplish any of these tasks we need to be able to traverse a tree:
    - Preorder traversal - visit the current node, then left child (all the way to the smallest child at the bottom of the tree), then right child (all the way to the largest child at the bottom of the tree)
    - Inorder traversal - vists left child, then current node, then right child
    - Postorder traversal - visits the left child, then the right child, then the current node
- Remove is the most complicated method