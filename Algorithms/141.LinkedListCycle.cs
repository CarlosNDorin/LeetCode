using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class LinkedListCycle
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;
            ListNode slow = head;
            if (head.next == null)
                return false;
            ListNode fast = head.next.next;
            while (fast.next != null)
            {
                if (slow == fast)
                    return true;
                slow = slow.next;
                fast = fast.next.next;
            }
            return false;

        }
    }
}
