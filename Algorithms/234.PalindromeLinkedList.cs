using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PalindromeLinkedList
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
 
        public ListNode createList(int amount)
        {
            ListNode root = new ListNode(0);
            ListNode dummy = root;
            for (int i = 1; i <= amount; i++)
            {
                dummy.next = new ListNode(i);
                dummy = dummy.next;
            }
            return root;

        }
       public bool IsPalindrome(ListNode head)
       {
            if (head == null || head.next == null)
                return true;

            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;
            bool odd = false;
            //find the medium

            int counter = 0;
            while(fast!= null)
            {
                slow = slow.next;
                if(fast.next == null)
                {
                    odd = true;
                    break;
                }
                fast = fast.next.next;
                counter++;
            }

            
            while(counter > 0 )
            {

                ListNode tmp = prev;
                prev = head;
                head = head.next;
                prev.next = tmp;
                counter--;
            }

            if(odd)
            {
                head = head.next;
            }
            while(prev != null)
            {
                if (prev.val != head.val)
                    return false;
                prev = prev.next;
                head = head.next;
            }
            return true;
       }
        
    }
}
