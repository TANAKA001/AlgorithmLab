using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Elements
{
    class BinaryTree
    {
        class Node
        {
            public int data;
            public Node left, right;
            public Node(int item)
            {
                data = item;
                left = null;
                right = null;
            }
        }
        Node Root;
        BinaryTree()
        {
            Root = null;
        }
        void Insert(int data) { }
    }
}
