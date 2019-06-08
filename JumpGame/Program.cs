using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[] { 3, 2, 1, 0, 4 };
            //  int[] nums = new int[] { 3, 0, 8, 2, 0, 0, 1};

            int[] nums = new int[25003];
            int index = 0;
            for (int i = 25000; i >= 1; i--)
            {
                nums[index] = i;
                index++;
            }

            nums[25000] = 1;
            nums[25001] = 0;
            nums[25002] = 0;

            bool result = CanJump(nums);
            Console.WriteLine(result);
            Console.Read();
        }

        public static bool CanJump(int[] nums)
        {
            Dictionary<int, bool> intermediateResults = new Dictionary<int, bool>();
            return JumpHelper(nums, intermediateResults);
        }

        public static bool JumpHelper(int[] nums, Dictionary<int, bool> intermediateResults)
        {
            bool canJump = false;
            if (nums.Length == 0) return false;
            if (nums.Length == 1) return true;

            // can not jump.
            if (nums[0] == 0) return false;

            // as atleast one jump can be made.
            if (nums.Length == 2) return true;

            if (nums.Distinct().Count() == 1 && nums[0] == 1) return true;

            int finalIndex = nums.Length - 1;

            for (int arrayIndex = 0; arrayIndex < nums.Length; arrayIndex++)
            {
                if (nums[arrayIndex] == 0) return false;

                for (int index = nums[arrayIndex]; index >=1; index--)
                {
                    //if((nums[0] - index == 1) && intermediateResults.ContainsKey(nums.Length - index -1))
                    //{
                    //    return intermediateResults[nums.Length - index -1];
                    //}

                    if (finalIndex - index <= 0) return true; // reached to the end.

                    if (intermediateResults.ContainsKey(nums.Length - index))
                    {
                        return intermediateResults[nums.Length - index];
                    }

                    int[] subArray = new int[nums.Length - index];
                    Array.Copy(nums, index, subArray, 0, nums.Length - index);
                    canJump = JumpHelper(subArray, intermediateResults);
                    intermediateResults.Add(subArray.Length, canJump);
                    if (canJump) break;
                }

                if (canJump) break;
            }

            return canJump;
        }
    }
}
