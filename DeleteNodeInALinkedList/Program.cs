using System;

namespace DeleteNodeInALinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constraints:
            //The number of the nodes in the given list is in the range[2, 1000].
            //-1000 <= Node.val <= 1000
            //The value of each node in the list is unique.
            //The node to be deleted is in the list and is not a tail node
            ListNode n1 = new ListNode(4);
            n1.next = new ListNode(5);
            n1.next.next = new ListNode(1);
            n1.next.next.next = new ListNode(9);
            Console.WriteLine(n1.ToString());
            Console.ReadLine();
        }
        public static void DeleteNode(ListNode node)
        {
            if (node.val >= -1000 && node.val <= 1000)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
    }
}
