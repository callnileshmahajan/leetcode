using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 3, 7, 5, 6, 4, 8 };
            MergeSort(numbers, 0, numbers.Length - 1);
            Console.Read();
        }

        private static void MergeSort(int[] numbers, int leftIndex, int rightIndex)
        {
            int arrayLength = numbers.Length;

            if (arrayLength == 1) return;

            // Finding the middle element.
            int mid = arrayLength / 2;

            int[] subArray1 = new int[mid];
            Array.ConstrainedCopy(numbers, 0, subArray1, 0, mid);

            int[] subArray2 = new int[arrayLength - mid];
            Array.ConstrainedCopy(numbers,  mid,subArray2, 0, arrayLength - mid);

            MergeSort(subArray1, leftIndex, mid);
            MergeSort(subArray2, mid + 1, rightIndex);

            Merge(numbers, subArray1, subArray2);
        }

        private static void Merge(int[] numbers, int[] subArray1, int[] subArray2)
        {
            int[] tempArray = new int[subArray1.Length + subArray2.Length];
            int k = 0;
            int i = 0;
            int j = 0;

            while (i < subArray1.Length && j < subArray2.Length)
            {
                if (subArray1[i] <= subArray2[j])
                {
                    tempArray[k] = subArray1[i];
                    i++;
                }
                else
                {
                    tempArray[k] = subArray2[j];
                    j++;
                }
                k++;
            }

            while (i < subArray1.Length)
            {
                tempArray[k] = subArray1[i];
                i++;
                k++;
            }

            while (j < subArray2.Length)
            {
                tempArray[k] = subArray2[j];
                j++;
                k++;
            }

            Array.Copy(tempArray, numbers, tempArray.Length);

        }
    }
}

