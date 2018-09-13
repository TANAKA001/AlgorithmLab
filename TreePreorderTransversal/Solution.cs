using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreePreorderTransversal
{

    public class Solution
    {
        List<int> preOrderResult = new List<int>();
        List<int> inOrderResult = new List<int>();
        List<int> postOrderResult = new List<int>();

        public Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }

                return root;
            }
        }
        public int count(Node h)
        {

            if (h == null) return 0;
            return count(h.left) + count(h.right) + 1;
        }

        public List<int> preOrder(Node root)
        {
            /*
             Pre-order (NLR)
             Pre Order - filho esquerda | filho direita | pai
             1 Check if the current node is empty or null.
             2 Display the data part of the root (or current node).
             3 Traverse the left subtree by recursively calling the pre-order function.
             4 Traverse the right subtree by recursively calling the pre-order function
              */

            if (root != null)
            {
                preOrderResult.Add(root.data);
                preOrder(root.left);
                preOrder(root.right);
            }
            return preOrderResult;

        }
        public List<int> inOrder(Node root)
        {
            /*
             In-order (LNR)
             In Order - filho | pai | filho
            1 Check if the current node is empty or null.
            2 Traverse the left subtree by recursively calling the in-order function.
            3 Display the data part of the root (or current node).
            4 Traverse the right subtree by recursively calling the in-order function.
            
            In a binary search tree, in-order traversal retrieves data in sorted order.[4] 
             */

            if (root != null)
            {
                inOrder(root.left);
                inOrderResult.Add(root.data);
                inOrder(root.right);
            }

            return inOrderResult;
        }
        public List<int> postOrder(Node root)
        {
            /*Post-order (LRN)[edit]
                Post Order - pai | filho esquerda | filho direita
                
            1 Check if the current node is empty or null.
            2 Traverse the left subtree by recursively calling the post-order function.
            3 Traverse the right subtree by recursively calling the post-order function.
            4 Display the data part of the root (or current node).
              
            The trace of a traversal is called a sequentialisation of the tree. 
            The traversal trace is a list of each visited root. No one sequentialisation according to pre-, in- or post-order 
            describes the underlying tree uniquely. Given a tree with distinct elements, either pre-order or post-order 
            paired with in-order is sufficient to describe the tree uniquely. However, pre-order with post-order leaves some 
            ambiguity in the tree structure.
             */

            if (root != null)
            {
                postOrder(root.left);
                postOrder(root.right);
                postOrderResult.Add(root.data);
            }

            return postOrderResult;
        }
        public void genericTree(Node root)
        {
            /*
             Generic tree[edit]
            To traverse any tree with depth-first search, perform the following operations recursively at each node: 
            1 Perform pre-order operation.
            2 For each i from 1 to the number of children do: 
                1 Visit i-th, if present.
                2 Perform in-order operation.
            3 Perform post-order operation.
            Depending on the problem at hand, the pre-order, in-order or post-order operations may be void, or you may 
            only want to visit a specific child, so these operations are optional. Also, in practice more than one of pre-order, 
            in-order and post-order operations may be required. For example, when inserting into a ternary tree, a pre-order operation 
            is performed by comparing items. A post-order operation may be needed afterwards to re-balance the tree. 
             */
        }


    } //End of Solution
}