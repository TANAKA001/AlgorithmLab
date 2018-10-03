using Global.Elements;
using System.Collections.Generic;
using System.Linq;

namespace Global.Generator
{
    public class LinkedListGenerator
    {
        public void ListNodes(LinkedNode head, ref List<int> list)
        {
            //if (head.next == null) return;

            //list.Add(head.val);
            //ListNodes(head.next, ref list);
        }
        public LinkedNode OneWayLiked(int size, ref List<int> list)
        {
            List<int> result = new List<int>();

            //ListNodes(head, ref result);

            LinkedNode newListNode = null;
            LinkedNode _head = null;

            for (int i = 1; i <= size; i++)
            {
                //newListNode = new LinkedNode(result[i]);
                newListNode = new LinkedNode(i);

                if (i == result.Count - 1)
                    _head = newListNode;

                //newListNode.next = new LinkedNode(result[i + 1]);
                newListNode.next = new LinkedNode(i+1);
                newListNode = newListNode.next;
            }

            return newListNode;
        }
    }
}
