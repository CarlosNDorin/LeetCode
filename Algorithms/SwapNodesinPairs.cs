using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SwapNodesinPairs
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode createList(int num)
        {
            ListNode head = new ListNode(-1);
            ListNode curr = head;
            for(int i = 1; i<= num; i++)
            {
                curr.next = new ListNode(i);
                curr = curr.next;
            }
            return head.next;

        }
        public ListNode SwapPairs(ListNode head)
        { 
            ListNode dummyHead = new ListNode(0);
            dummyHead.next = head;
            ListNode prev = dummyHead;
            ListNode curr = head;

            while (curr != null && curr.next != null)
            {
                ListNode next = curr.next;
                ListNode nextnext = next.next;
                prev.next = next;
                next.next = curr;
                curr.next = nextnext;

                prev = curr;
                curr = curr.next;
            }

            return dummyHead.next;
        }
    }
}
