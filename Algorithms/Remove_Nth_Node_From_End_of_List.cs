using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
 public  class Remove_Nth_Node_From_End_of_List
    {
      public class ListNode
      {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
      }
 
     public ListNode RemoveNthFromEnd(ListNode head, int n)
     {
            if (head == null || n == 0) return head;
            if (head.next == null && n == 1) return null; // this case had been included in below code, so it can be removed

            ListNode tempHead = new ListNode(0);
            tempHead.next = head;
            int count = 0, index = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }

            head = tempHead;
            while (index < count - n)
            {
                head = head.next;
                index++;
            }
            if (head.next.next != null)
            {
                head.next = head.next.next;
            }
            else
            {
                head.next = null;
            }

            return tempHead.next;
            /*
                        int count = 0;
                        ListNode newListNode = new ListNode(-1);
                        newListNode.next = head;
                        if (n == 0)
                        {
                            head = head.next;
                            return head;
                        }
                        while (n != count - 1)
                        {
                            head = head.next;
                            count++;
                        }
                        head = head.next.next;
                        while (newListNode != null)
                        {
                            Console.WriteLine(newListNode.val);
                            newListNode = newListNode.next;
                        }
                        return newListNode;
              */
        }
        
    }
}
