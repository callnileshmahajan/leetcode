using System;

namespace LinkedListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // var iNode = new ListNode(8);
            // iNode.next = new ListNode(4);
            // iNode.next.next = new ListNode(5);
            // iNode.next.next.next = null;

            //ListNode headA = new ListNode(4);
            // headA.next = new ListNode(1);

            // ListNode headB = new ListNode(5);
            // headB.next = new ListNode(0);
            // headB.next.next = new ListNode(1);

            // headA.next.next = iNode;
            // headB.next.next.next = iNode;

            var iNode = new ListNode(3);
            iNode.next = null;

            ListNode headA = iNode;

            ListNode headB = new ListNode(2);
            headB.next = iNode;

            var result = GetIntersectionNode(headA, headB);
            Console.WriteLine(result.val);
            Console.Read();
        }

        /// <summary>
        /// The logic is to move get the difference of the in the linked list count and then start with the counter location
        /// e.g. if two list 4-1-8-4-5 and 5-0-1-8-4-5 then move second list one counter as its size is 1 more to than first one.
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;
            if (headA ==  headB) return headA;

            int cA = NodeCounter(headA);
            int cB = NodeCounter(headB);

            if(cA > cB)
            {
                int move = cA - cB;
                while(move > 0)
                {
                    headA = headA.next;
                    move--;
                }
            }
            else
            {
                int move = cB - cA;
                while (move > 0)
                {
                    headB = headB.next;
                    move--;
                }
            }

            while(headA != null && headB != null)
            {
                if (headA == headB)
                    return headA;

                headA = headA.next;
                headB = headB.next;
            }

            return null;
        }

        private static int NodeCounter(ListNode list)
        {
            int count = list != null ? 1 : 0;

            while(list.next != null)
            {
                list = list.next;
                count++;
            }

            return count;
        }
    }

  public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
}
