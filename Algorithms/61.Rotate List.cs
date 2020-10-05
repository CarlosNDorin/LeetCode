using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class RotateList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode createList(int i)
        {
            ListNode root = new ListNode(0);
            ListNode dummy = root;
            for(int x = 1; x <= i; x++)
            {
                dummy.next = new ListNode(x);
                dummy = dummy.next;
            }
            return root;
        }
        public ListNode RotateRight(ListNode head, int k)
        {
            ListNode root = head;
           
            int amount = 0;
            while(head != null)
            {
                amount++;
                head = head.next;
            }
            if (amount == 0 || amount == 1)
                return root;

            if (k > amount)
                k %= amount;

            if (k == amount)
                return root;

            if ( k == 0)
                return root;

            head = root;

            for(int i = 0; i < amount - k-1 ; i++)
            {
                head = head.next;
            }

            ListNode newRoot = head.next;
            ListNode dummy = newRoot;

            while(dummy.next != null)
            {
                dummy = dummy.next;
            }
            head.next = null;
            dummy.next = root;
            return newRoot;
        }
    }
}
