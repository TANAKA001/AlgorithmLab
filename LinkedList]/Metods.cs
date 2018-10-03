using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Global;
using Global.Elements;

namespace LinkedList
{
    public class Metods
    {
        public LinkedNode ReverseList(LinkedNode head)
        {
            List<int> result = new List<int>();

            ListNodes(head, ref result);

            LinkedNode newListNode;
            LinkedNode _head = null;

            for (int i = result.Count - 1; i > 1; i--)
            {
                newListNode = new LinkedNode(result[i]);

                if (i == result.Count - 1)
                    _head = newListNode;

                newListNode.next = new LinkedNode(result[i - 1]);
                newListNode = newListNode.next;
            }

            return _head;
        }

        public void ListNodes(LinkedNode head, ref List<int> list)
        {
            if (head.next == null) return;

            list.Add(head.val);
            ListNodes(head.next,ref list);
        }
    }
}
