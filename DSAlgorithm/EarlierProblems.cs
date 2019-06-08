using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    public class EarlierProblems
    {

        //int[] nums = new int[] { -1, -2, -3, -4, -5 };
        //int target = -8;

        //var result = TwoSum(nums, target);
        //Console.WriteLine($"{result[0]}, {result[1]}");
        /// <summary>
        /// Sum of two numbers equals to target. Find the indexes of those number.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2] { -1, -1 };
            if (nums == null || !nums.Any())
                return result;

            int[] numsBackup = new int[nums.Length];
            Array.Copy(nums, numsBackup, nums.Length);

            // Sorting the array
            Array.Sort(nums);
            int num1 = int.MinValue;
            int num2 = int.MinValue;
            bool isFound = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        num1 = nums[i];
                        num2 = nums[j];
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                    break;
            }

            int resultIndex = 0;

            for (int i = 0; i < numsBackup.Length; i++)
            {
                if (numsBackup[i] == num1 || numsBackup[i] == num2)
                {
                    result[resultIndex] = i;
                    resultIndex++;
                }
            }

            return result;
        }

        //int[] s1AsciiArray = new int[s1.Length];
        //int[] s2AsciiArray = new int[s2.Length];

        //int index = 0;
        //foreach (var ch in s1)
        //{
        //    s1AsciiArray[index] = ch;
        //    index++;
        //}

        //foreach (var ch in s2)
        //{
        //    s2AsciiArray[index] = ch;
        //    index++;
        //}
    }
}
