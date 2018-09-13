using Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreePreorderTransversal
{
    class Program
    {
        static int Main(string[] args)
        {
            Solution myTree = new Solution();
            Node root = null;

            int t;
            int data;

            t = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

            while (t-- > 0)
            {
                data = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
                root = myTree.insert(root, data);
            }

            Console.WriteLine(myTree.count(root));
            Console.WriteLine(myTree.preOrder(root).ToArray<int>());
            Console.WriteLine(myTree.inOrder(root).ToArray<int>());
            Console.WriteLine(myTree.postOrder(root).ToArray<int>());
            //Console.WriteLine(myTree.count(root));

            return 0;

      }
    }
}
 