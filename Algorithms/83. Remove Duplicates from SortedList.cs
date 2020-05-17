using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class RemoveDuplicatesfromSortedList
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
            for (int i = 1; i <= num; i++)
            {
                curr.next = new ListNode(1);
                curr = curr.next;
            }
            return head.next;
        }
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return head;
            ListNode curr = head.next;
            ListNode prev = head;
            while(curr != null)
            {
                if(prev.val == curr.val)
                {
                    prev.next = curr.next;
                    curr = curr.next;
                }
                else
                {
                    prev = curr;
                    curr = curr.next;
                }
            }
            return head;
        }
    }
}
