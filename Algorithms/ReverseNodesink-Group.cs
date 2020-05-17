using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ReverseNodesink_Group
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
                curr.next = new ListNode(i);
                curr = curr.next;
            }
            return head.next;
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var KlengthList = new List<ListNode>();

            //divide the list into group

            KlengthList.Add(head);

            var runner = head;
            var newHeader = head;
            int length = 1;

            while (runner != null)
            {
                if (length == k)
                {
                    KlengthList.Add(runner.next);
                    length = 1;
                    var temp = runner.next;
                    runner.next = null;
                    runner = temp;
                    continue;
                }

                length += 1;
                runner = runner.next;
            }

            var KlengthListEnd = new List<ListNode>();

            //reverse k length list

            for (int i = 0; i < KlengthList.Count - 1; i++)
            {
                KlengthListEnd.Add(ReverseList(KlengthList[i]));
            }

            if (length == k + 1)// El ultimo Linked List, va a tener igual o menos Nodos
                //Si tienen igual, lo reverse y agrego, Si no, lo agrego asi como esta.
            {
                KlengthListEnd.Add(ReverseList(KlengthList[KlengthList.Count - 1]));
            }
            else
            {
                KlengthListEnd.Add(KlengthList[KlengthList.Count - 1]);
            }

            //link reversed list together

            for (int i = 0; i < KlengthList.Count - 1; i++)
            {
                KlengthList[i].next = KlengthListEnd[i + 1];
            }

            return KlengthListEnd[0];
        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode newHead = null;

            var next = head;

            while (next != null)
            {
                var temp = next.next;
                next.next = newHead;
                newHead = next;
                next = temp;
            }

            return newHead;
        }
    }
}
