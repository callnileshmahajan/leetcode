using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode startNode1 = new ListNode(5);
            startNode1.next = null;

            //var nextNode = new ListNode(4);
            //nextNode.next = startNode1;

            //startNode1 = nextNode;

            //nextNode = new ListNode(2);
            //nextNode.next = startNode1;

            //startNode1 = nextNode;

            ListNode startNode2 = new ListNode(5);
            startNode2.next = null;

            //var nextNode = new ListNode(9);
            //nextNode.next = startNode2;

         //   startNode2 = nextNode;

            //nextNode = new ListNode(9);
            //nextNode.next = startNode2;

            //startNode2 = nextNode;
            //nextNode = new ListNode(9);
            //nextNode.next = startNode2;

            //startNode2 = nextNode;
            //nextNode = new ListNode(9);
            //nextNode.next = startNode2;

            //startNode2 = nextNode;
            //nextNode = new ListNode(9);
            //nextNode.next = startNode2;

            //startNode2 = nextNode;
            //nextNode = new ListNode(9);
            //nextNode.next = startNode2;

            //startNode2 = nextNode;
            //nextNode = new ListNode(9);
            //nextNode.next = startNode2;

            //startNode2 = nextNode;
            //nextNode = new ListNode(9);
            //nextNode.next = startNode2;

         //   startNode2 = nextNode;
            //nextNode = new ListNode(1);
            //nextNode.next = startNode2;

            //startNode2 = nextNode;

           var result =  AddTwoNumbers(startNode1, startNode2);

            Console.Read();
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            int digit1;
            int digit2;

            ListNode headerNode = null;
            
            while (l1 != null || l2 != null)
            {
                digit1 = l1 != null ?  l1.val : 0;
                digit2 = l2 != null ? l2.val : 0;

                int tempSum = digit1 + digit2 + carry;
                int sumDigit;
                if (tempSum >= 10)
                {
                    sumDigit = tempSum % 10;
                    carry = tempSum / 10;
                }
                else
                {
                    sumDigit = tempSum;
                    carry = 0;
                }

                if (headerNode == null)
                {
                    headerNode = new ListNode(sumDigit);
                    headerNode.next = null;
                }
                else
                {
                    AddElementToList(headerNode, sumDigit);
                }

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            } 

            if(carry > 0)
            {
                AddElementToList(headerNode, carry);
            }

            return headerNode;
        }

        private static void AddElementToList(ListNode headerNode, int digit)
        {
            ListNode currentNode = new ListNode(digit);
            currentNode.next = null;

            // now move down to end of the list and add.
            ListNode tempNode = headerNode;

            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }

            tempNode.next = currentNode;
        }

        // note : Following method also works but with long numbers.
        //public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    long multiplier = 1;
        //    List<int> sumDigits = new List<int>();
        //    long number1 = 0;
        //    long number2 = 0;

        //    while (l1 != null)
        //    {
        //        var digit1 = (long)l1.val;
        //        digit1 = digit1 * multiplier;
        //        multiplier *= 10;
        //        number1 = number1 + digit1;
        //        l1 = l1.next;
        //    }

        //    multiplier = 1;

        //    while (l2 != null)
        //    {
        //        var digit1 = (long)l2.val;
        //        digit1 = digit1 * multiplier;
        //        multiplier *= 10;
        //        number2 = number2 + digit1;
        //        l2 = l2.next;
        //    }

        //    long  toalSum = number1 + number2;

        //    ListNode startNode = null;

        //    List<int> digits = new List<int>();

        //    if (toalSum == 0) digits.Add(0);

        //    while (toalSum > 0)
        //    {
        //        long digit = toalSum % 10;
        //        toalSum = toalSum / 10;
        //        digits.Add((int)digit);
        //    }



        //    for (int i = digits.Count -1; i >= 0; i--)
        //    {
        //        if (startNode == null)
        //        {
        //            startNode = new ListNode(digits[i]);
        //            startNode.next = null;
        //        }
        //        else
        //        {
        //            ListNode tempNode = new ListNode(digits[i]);
        //            tempNode.next = startNode;

        //            startNode = tempNode;
        //        } 
        //    }

        //    return startNode;
        //}
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
