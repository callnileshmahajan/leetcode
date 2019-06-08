using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 21, 47, 80, 4, 24, 87, 22, 6, 89, 80, 74, 74, 55, 58, 56, 98, 66, 49, 27, 78, 24, 69, 88, 80, 65, 72, 5, 64, 7, 37, 2, 75, 93, 79, 39, 85, 26, 93, 74, 89, 27, 57, 45, 73, 25, 33, 38, 58 };

            ShellSort(ref numbers);
            foreach (var item in numbers)
            {
                Console.Write(item);
                Console.Write(',');
            }

            Console.Read();
        }

        private static void ShellSort(ref int[] numbers)
        {
            int gap = numbers.Length / 2;
            int end;
            int i = 0;

            while (gap >=1)
            {
                end = i + gap;

                if (numbers[i] > numbers[i + gap])
                {
                    Swap(ref numbers, i, i + gap);

                    int previousPairsCheck = end - 1;

                    while (previousPairsCheck >= gap)
                    {
                        if (numbers[previousPairsCheck - gap] > numbers[previousPairsCheck])
                        {
                            Swap(ref numbers, previousPairsCheck - gap, previousPairsCheck);
                        }
                        else
                            break;

                        previousPairsCheck--;
                    }
                }

                i++;

                if (i + gap >= numbers.Length)
                {
                    gap = gap / 2;
                    i = 0;
                }
            }
        }

        //private static void ShellSort(ref int[] numbers)
        //{
        //    int gap = numbers.Length / 2;
        //    int end;
        //    int i = 0;
        //    while (gap >= 1)
        //    {
        //        while (true)
        //        {
        //            if (i + gap >= numbers.Length) break;
        //            end = i + gap;

        //            if (numbers[i] > numbers[i + gap])
        //            {
        //                Swap(ref numbers, i, i + gap);

        //                int previousPairsCheck = end-1;

        //                while (previousPairsCheck >= gap)
        //                {
        //                    if (numbers[previousPairsCheck - gap] > numbers[previousPairsCheck])
        //                    {
        //                        Swap(ref numbers, previousPairsCheck - gap, previousPairsCheck);
        //                    }
        //                    else
        //                        break;

        //                    previousPairsCheck--;
        //                }
        //            }

        //            i++;
        //        }

        //        gap = gap / 2;
        //        i = 0;
        //    }
        //}

        private static void Swap(ref int[] numbers, int index1, int index2)
        {
            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;
        }
    }
}
