using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Elements
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
        //void Insert(int data);
    }
}
