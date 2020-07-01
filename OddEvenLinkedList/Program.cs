using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenLinkedList
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
           // head.next.next.next.next.next = new ListNode(6);
            head.next.next.next.next.next= null;

            var result = OddEvenList(head);
            Console.Read();
        }

        /// <summary>
        /// Current solution is a recursive solution where first we reach to second last odd node and swap it with last even node.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode OddEvenList(ListNode head)
        {
            int moveCounter = 1;
            
            return OddEvenListHepler(head, GetNextOddNode(head), ref moveCounter);
        }

        private static ListNode OddEvenListHepler(ListNode oddNode, ListNode nextOddNode, ref int moveCounter)
        {
            if (oddNode == null) return oddNode;
            if (oddNode.next == null) return oddNode;

            if (nextOddNode == null) return oddNode;

            if (oddNode.next.next.next == null)// Three elements.
            {
                ListNode temp = oddNode.next;
                oddNode.next  = oddNode.next.next;
                temp.next = null;
                oddNode.next.next = temp;
                moveCounter = moveCounter + 1;

                return oddNode;
            }
            else
            {
                var tempOddNode = GetNextOddNode(nextOddNode);
                var tempList = OddEvenListHepler(nextOddNode, tempOddNode, ref moveCounter);

                ListNode temp = oddNode.next; // to be inserted.

                for (int i = 0; i < moveCounter -1; i++)
                {
                    tempList = tempList.next;
                }

                temp.next = tempList.next;
                tempList.next = temp;
                oddNode.next = nextOddNode;
                moveCounter++;
                return oddNode;
            }
        }

        private static ListNode GetNextOddNode(ListNode currentOddNode)
        {
            int counter = 1;
            while (counter < 3 && currentOddNode.next != null)
            {
                currentOddNode = currentOddNode.next;
                counter++;
            }

            if (counter < 3)
                return null; // as no further odd node found;
            else
                return currentOddNode;
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
