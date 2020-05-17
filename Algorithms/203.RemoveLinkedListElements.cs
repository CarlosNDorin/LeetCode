using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class RemoveLinkedListElements
    {
        public class ListNode
        {
             public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;
            while (head.val == val)
            {
                if (head.next == null)
                    return null;
                head = head.next;
            }

            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            ListNode curr = dummy;
            ListNode next = curr.next;

            while (next != null)
            {
                if (next.val != val)
                {
                    curr = next;
                    next = next.next;
                }
                else
                {
                    while (next.val == val)
                    {
                        if (next.next == null)
                        {
                            curr.next = null;
                            return dummy.next;
                        }
                        next = next.next;
                        curr.next = next;
                    }
                }
            }
            return dummy.next;
        }
    }
}
