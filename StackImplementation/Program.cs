using System;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(10);
            myStack.Push(11);
            myStack.Push(12);
            myStack.Push(13);
            myStack.Push(14);
            myStack.Push(15);

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());


            Console.Read();
        }  
        
        public struct Stack
        {
            int[] Items;

           public void Push(int value)
            {
                if (Items == null)
                {
                    Items = new int[1];
                    Items[0] = value;
                }

                Array.Resize(ref Items, Items.Length + 1);
                Items[Items.Length - 1] = value;
            }

            public int Pop()
            {
                if (Items == null) return -1;

                int value = Items[Items.Length - 1];
                Array.Resize(ref Items, Items.Length - 1);
                return value;
            }
        }
    }
}
