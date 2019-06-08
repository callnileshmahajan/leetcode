using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            queue.Push(1);
            queue.Push(2);
            Console.WriteLine(queue.Pop());
            queue.Push(3);
            queue.Push(4);
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Peek());  // returns 1
            //Console.WriteLine(queue.Pop());   // returns 1
            //Console.WriteLine(queue.Empty()); // returns false

            Console.Read();
        }
    }

    public class MyQueue
    {
        private Stack<int> _localStack;
        private List<int> _dataStore;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            _localStack = new Stack<int>();
            _dataStore = new List<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (_localStack.Count == 0)
            {
                _localStack.Push(x);
                _dataStore.Add(x);
            }
            else
            {
                _localStack.Clear();

                _localStack.Push(x);

                for (int i = _dataStore.Count - 1; i >= 0; i--)
                {
                    _localStack.Push(_dataStore[i]);
                }

                _dataStore.Add(x);

            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (_localStack.Count > 0)
            {
                _dataStore.RemoveAt(0);
                return _localStack.Pop();
            }
            else return -1;
        }

        /** Get the front element. */
        public int Peek()
        {
            return _localStack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return _localStack.Count == 0;
        }
    }
}
