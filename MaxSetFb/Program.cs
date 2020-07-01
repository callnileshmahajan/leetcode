using System;
using System.Collections;
using System.Collections.Generic;

namespace MaxSetFb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,2,3,4 };

            GetAllSubSets(nums);
            Console.Read();
        }

        /// <summary>
        /// The idea is to mark the item to be included or not included.
        /// </summary>
        /// <param name="nums"></param>
        private static void GetAllSubSets(int[] nums)
        {
            int[] subset= new int[nums.Length];
            Array.Copy(nums, subset, nums.Length);
            Helper(nums, subset, 0);
        }

        private static void Helper(int[] nums, int[] subset, int i)
        {
            if (i == nums.Length)
                Print(subset);
            else
            {
                subset[i] = -1;
                Helper(nums, subset, i + 1);
                subset[i] = nums[i];
                Helper(nums, subset, i + 1);
            }
        }

        private static void Print(int[] subset)
        {
            for (int i = 0; i < subset.Length; i++)
            {
                if (subset[i] == -1)
                    Console.Write("");
                else
                {
                    Console.Write(subset[i]);
                    Console.Write(',');
                }
            }
            Console.WriteLine(Environment.NewLine);
        }

        private static void FindAndPrintSubSet(int[] nums, Dictionary<string, bool> printed)
        {
            if (nums.Length == 0 && !printed.ContainsKey("_"))
            {
                Console.WriteLine('_');
                printed.Add("_", true);
                return;
            }

            if(nums.Length == 1)
            {
                if (!printed.ContainsKey("_"))
                {
                    Console.WriteLine('_');
                    printed.Add("_", true);
                }

                if (!printed.ContainsKey($"{nums[0]}"))
                {
                    Console.WriteLine($"{nums[0]}");
                    printed.Add($"{nums[0]}", true);
                }
                return;
            }

            int[] firstSubArray = new int[nums.Length - 1];
            Array.Copy(nums, 0, firstSubArray, 0, nums.Length - 1);
            FindAndPrintSubSet(firstSubArray, printed);

            int[] secondSubArray = new int[nums.Length - 1];
            Array.Copy(nums, 1, secondSubArray, 0, nums.Length - 1);
            FindAndPrintSubSet(secondSubArray, printed);

            var key = string.Join(',', nums[0], nums[nums.Length -1]);

            if (!printed.ContainsKey(key))
            {
                Console.WriteLine(key);
                printed.Add(key, true);
            }

            if (!printed.ContainsKey(string.Join(',', nums)))
            {
                Console.WriteLine(string.Join(',', nums));
                printed.Add(string.Join(',', nums), true);
            }
        }
    }
}
