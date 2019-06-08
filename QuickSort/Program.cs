using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = new int[6] { 6, 3, 5, 4, 2, 9 };
           int[] input = new int[] { 15, 7, 9, 4, 12, 6, 22, 8, 33, 25, 5, 18, 13};
           // int[] input = new int[6] { 10, 80, 90, 60, 30, 20 };

            QuickSort(ref input, 0, input.Length - 1);
            Console.Read();
        }

        // n = 6
        // [15,7,9,4,12,6]
        private static void QuickSort(ref int[] input, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            int pivotIndex = Partition(ref input, leftIndex, rightIndex);

            QuickSort(ref input, leftIndex, pivotIndex - 1);
            QuickSort(ref input, pivotIndex + 1, rightIndex);
        }

        private static int Partition(ref int[] input, int leftIndex, int rightIndex)
        {
            int pivot = input[leftIndex];
            int pivotIndex = leftIndex; // By default first element in the array pivot.

            while (true)
            {
                for (int i = rightIndex; i >= pivotIndex; i--)
                {
                    if (input[i] < pivot)
                    {
                        Swap(ref input, pivotIndex, i);
                        pivotIndex = i;
                        rightIndex = i;
                        break;
                    }
                }

                if (pivotIndex <= leftIndex) break;  // nothing changed. Pivot is at its location.

                for (int i = leftIndex; i < pivotIndex; i++)
                {
                    if (input[i] > pivot)
                    {
                        Swap(ref input, pivotIndex, i);
                        pivotIndex = i;
                        leftIndex = i;
                        break;
                    }
                }

                if (pivotIndex == rightIndex) break;                 
            }

            return pivotIndex;
        }

        private static void Swap(ref int[] input, int pivotIndex, int elementIndex)
        {
            int temp = input[pivotIndex];
            input[pivotIndex] = input[elementIndex];
            input[elementIndex] = temp;
        }
    }
}
