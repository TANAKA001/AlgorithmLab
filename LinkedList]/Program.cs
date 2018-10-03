using Global.Elements;
using Global.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListGenerator llg = new LinkedListGenerator();
            List<int> _linkedList = new List<int>();
            LinkedNode linkNode = llg.OneWayLiked(10 ,ref _linkedList);

            Metods _metods = new Metods();
            _metods.ReverseList(linkNode);
        }
    }
}
