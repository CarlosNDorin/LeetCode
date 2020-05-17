using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ReverseLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode createList (int n)
        {
            ListNode root = new ListNode(0);
            ListNode dummy = root;
            for (int i = 1; i<= n; i++ )
            {
                dummy.next =  new ListNode(i);
                dummy = dummy.next;
            }
            return root;
        }
        public ListNode ReverseList(ListNode head)
        {
            if (head.next == null)
                return head;

            ListNode prev = null;
            
            while(head != null)
            {
                ListNode tmp = prev;
                prev = head;
                head = head.next;
                prev.next = tmp;
            }
            return prev;
        }
    }
}
