using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLComponent
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = null;

            var result = NumComponents(head, new int[] { 0, 3, 1, 4 });

            Console.Read();
        }

        public static int NumComponents(ListNode head, int[] G)
        {
            HashSet<int> tempG = new HashSet<int>();

            for (int i = 0; i < G.Length; i++)
            {
                tempG.Add(G[i]);
            }

            int count = 0;
            var currntNode = head;
            bool connectionFound = false;

            while (currntNode != null)
            {
                if(tempG.Contains(currntNode.val))
                {
                    connectionFound = true;
                    currntNode = currntNode.next;
                    continue;
                }
                else if(connectionFound)
                {
                    count++;
                    connectionFound = false;    
                }

                currntNode = currntNode.next;
            }

            if (connectionFound)
                count++;

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
