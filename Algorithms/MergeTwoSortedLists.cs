using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
  
 
    class MergeTwoSortedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            var dummy = new ListNode(-1);
            var cur = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            while (l1 != null)
            {
                cur.next = l1;
                cur = cur.next;
                l1 = l1.next;
            }

            while (l2 != null)
            {
                cur.next = l2;
                cur = cur.next;
                l2 = l2.next;
            }
            return dummy.next;
        }
    }
}
