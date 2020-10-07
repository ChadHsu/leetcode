using System;

namespace RemoveLinkedListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ln = new ListNode();
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(6);
            ListNode n4 = new ListNode(3);
            ListNode n5 = new ListNode(4);
            ListNode n6 = new ListNode(5);
            ListNode n7 = new ListNode(6);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = n7;
            n7.next = null;
            ln = RemoveElements(n1, 6);
            Console.WriteLine(ln.ToString());
            Console.ReadLine();
        }
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return head;
            //until head != val
            while(head.next != null && head.val == val)
            {
                head = head.next;
            }

            ListNode pre = head;
            ListNode curr = head.next;
            while(curr != null)
            {
                if (curr.val != val)
                {
                    pre.next = curr;
                    pre = curr;
                }
                curr = curr.next;
            }
            if (pre != null)
                pre.next = null;

            return head;
        }
    }
}
