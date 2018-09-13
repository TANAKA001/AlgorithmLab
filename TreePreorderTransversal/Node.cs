using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreePreorderTransversal
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int d)
        {
            data = d;
            left = null;
            right = null;
        }
    }
    class BinaryTree{
        class Node{
            public int data;
            public Node left, right;
            Public Node(int item){
                data = item;
                left = null;
                right = null;
            }
        }
        Node Root;
        BinaryTree(){
            Root = null;
        }
        void insert(int data);
    }
}
