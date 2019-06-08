using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = null;

            var result = ReverseList(head);
            Console.Read();
        }

        public static ListNode ReverseList(ListNode head)
        {
             var reverseList = ReverseListHelper(head);
            return reverseList;
        }

        private static ListNode ReverseListHelper(ListNode currentNode)
        {
            if (currentNode == null || currentNode.next == null) return currentNode;

            var node = ReverseListHelper(currentNode.next);
            currentNode.next.next = currentNode;
            currentNode.next = null;
            return node;
        }

        // Note: working 
        //public static ListNode ReverseList(ListNode head)
        //{
        //    ListNode reverseList = null;
        //    var currentNode = head;

        //    while (currentNode != null)
        //    {
        //        if(reverseList == null)
        //        {
        //            reverseList = new ListNode(currentNode.val);
        //            reverseList.next = null;
        //        }
        //        else
        //        {
        //            var tempNode = new ListNode(currentNode.val);
        //            tempNode.next = reverseList;
        //            reverseList = tempNode;
        //        }

        //        currentNode = currentNode.next;
        //    }

        //    return reverseList;
        //}
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
