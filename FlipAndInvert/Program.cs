using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipAndInvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inArray = new int[] { 1, 1, 0 };
            FlipArray(ref inArray);
            Console.Read();
        }

        private static void FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i < A.GetLength(1) - 1 ; i++)
            {
                FlipArray(ref A[i]);
                InvertImage(ref A[i]);
            }

        }

        private static void FlipArray(ref int[] inArray)
        {
            //inArray = inArray.Reverse().ToArray();
            int i, j;
            i = 0;
            j = inArray.Length-1;

           while(i < j)
            {
                Swap(ref inArray, i, j);
                i++;
                j--;
            }
        }

        private static void Swap(ref int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }

        private static void InvertImage(ref int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
            {
                if (inArray[i] == 0) inArray[i] = 1;
                else if(inArray[i] == 1) inArray[i] = 0;
            }
        }
    }
}
