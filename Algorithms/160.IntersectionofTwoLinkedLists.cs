using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class IntersectionofTwoLinkedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;
            int lenghtA = ListLenght(headA);
            int lenghtB = ListLenght(headB);
            int diff = Math.Abs(lenghtA - lenghtB);
            if (lenghtA < lenghtB)
            {
                while (diff != 0)
                {
                    headB = headB.next;
                    diff--;
                }
            }
            else
            {
                while (diff != 0)
                {
                    headA = headA.next;
                    diff--;
                }
            }

            while(headA != null || headB !=null)
            {
                if (headA == headB)
                    return headA;
                headA = headA.next;
                headB = headB.next;
            }
            return null;
        }

        public int ListLenght(ListNode node)
        {
            int lenght = 0;
            while(node != null)
            {
                lenght++;
                node = node.next;
            }
            return lenght;
        }
    }
}
