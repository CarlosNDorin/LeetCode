using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Merge_k_Sorted_Lists
    {
         public class ListNode
         {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
         }

        public ListNode[] CreateListNodes()
        {
            //creo 3 listas stam como el ejemplo.  1->4->5, 1->3->4, 2->6
            List<ListNode> listOfList = new List<ListNode>();
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(5);
            listOfList.Add(l1);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);
            listOfList.Add(l2);

            ListNode l3 = new ListNode(2);
            l3.next = new ListNode(6);
            listOfList.Add(l3);

            return listOfList.ToArray();
        }
        public ListNode MergeKLists(ListNode[] lists)
        {

            List<int> listNodes = new List<int>();

            foreach(ListNode node in lists)
            {
                var currnode = node; // Por alguna razon no me deja...
                while(currnode != null)
                {
                    listNodes.Add(currnode.val);
                    currnode = currnode.next;
                }
            }

            if (listNodes.Count == 0)
                return null;

            listNodes.Sort();
            ListNode newHead = new ListNode(-1);
            var curr = newHead;
            curr.val = listNodes.First();
            listNodes.RemoveAt(0);

            while (listNodes.Count != 0)
            {
                curr.next = new ListNode(listNodes.First());
                listNodes.RemoveAt(0);
                curr = curr.next;
            }

            return newHead;
        }
    }
}
