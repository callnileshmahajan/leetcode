using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayRemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            var result = Rob(nums);
            //   [6,3,10,8,2,10,3,5,10,5,3]
            Console.WriteLine(result);
            Console.ReadLine();
        }

        #region Longest squence

        /// <summary>
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LengthOfLISRecursive(int[] nums, int curpos, int prev)
        {
            if (nums.Length == curpos) return 0;

            int taken = 0;
            if (nums[curpos] > prev)
                taken = 1 +  LengthOfLISRecursive(nums, curpos + 1, nums[curpos]);

            int notTaken = LengthOfLISRecursive(nums, curpos + 1, prev);

            return Math.Max(taken, notTaken);
        }

        /// <summary>
        /// Following logic is base on taking each element at a time. 
        /// Record index of first decreasing element. Next iteration will start from that elment.
        /// Maintain a max sequest to hold the largest squence so far.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;

            int maxSq = 1;
            int l = 0;
            int count = 1;
            bool lset = false;
            int pMax;

            for (int i = 0; i < nums.Length; i++)
            {
                pMax = nums[l];
                for (int j = l; j < nums.Length - 1; j++)
                {
                    if (pMax < nums[j + 1])
                    {
                        pMax = nums[j + 1];
                        count++;
                        continue;
                    }
                    else if (!lset)
                    {
                        l = j + 1;
                        lset = true;
                    }
                }

                if (maxSq < count)
                    maxSq = count;

                count = 1; // Resetting the count.
                lset = false;

                if (l >= nums.Length - 1)
                    break;
            }

            return maxSq;
        }
        #endregion

        #region HouseRober

        /// <summary>
        /// The idea is to iterate through the list and find the sum with respect to current element. Max sum inclusive current element or exclusive current element.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            if (nums.Length == 2) // return whicever is max
            {
                if (nums[0] > nums[1])
                    return nums[0];
                else
                    return nums[1];
            }

            int[] inclSums = new int[nums.Length];
            int[] exclSums = new int[nums.Length];
            inclSums[0] = nums[0];
            exclSums[0] = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                inclSums[i] = exclSums[i - 1] + nums[i];
                exclSums[i] = Math.Max(exclSums[i - 1], inclSums[i -1]);
            }

            return Math.Max(inclSums[inclSums.Length - 1], exclSums[exclSums.Length -1]);
        }

        //public int Rob(int[] nums)
        //{
        //    var dp = new int[nums.Length + 1];

        //    if (nums == null || nums.Length == 0) return 0;

        //    dp[0] = 0;
        //    dp[1] = nums[0];

        //    for (var i = 1; i < nums.Length; i++)
        //    {
        //        dp[i + 1] = Math.Max(nums[i] + dp[i - 1], dp[i]);
        //    }

        //    return dp[nums.Length];
        //}

        #endregion

        #region Maximum SubArray

        public static int ShortestSubarray(int[] nums, int k)
        {
            int curSum = 0;
            int index = 0;
            int minSum;

            for (int i = 0; i < nums.Length; i++)
            {
                index = i;
                curSum += nums[i];

                if (curSum == k)
                    break;

                if (curSum > k)
                {
                    if (i - 1 < nums.Length && i -1 > 0)
                    {
                        minSum = nums[i - 1];
                        curSum = minSum + nums[i];
                    }
                    else
                        curSum = nums[i];

                    if (curSum == k)
                        break;
                }                   
            }

            if (index == nums.Length -1 && curSum != k)
                return -1;

            return index + 1;
        }

        /// <summary>
        /// Best logic. *****************
        /// Iterate through arr while maintaining curSum
        //  Any negative number will not contribute to the future maximum. So remove it.
        // Therefore, if curSum becomes negative, reset curSum to 0
        //Similar to sliding window, where we update window if prefix is negative
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray1(int[] nums)
        {
            int curSum = 0;
            int maxSub = nums[0];
            
            foreach (var n in nums)
            {
                if (curSum < 0)
                    curSum = 0;

                curSum += n;

                maxSub = Math.Max(maxSub, curSum);
            }

            return maxSub;
        }

        public static int MaxSubArray(int[] nums)
        {
            List<int> sums = new List<int>();
            Dictionary<string, int> memoize = new Dictionary<string, int>();
            //GetSubArraySum(nums, sums, memoize);
            GetSubArraySum(nums, 0, nums.Length - 1, sums, memoize);
            return sums.Max();
        }

        private static void GetSubArraySum(int[] nums, List<int> sums, Dictionary<string, int> memoize)
        {
            if (nums.Length == 1)
            {
                sums.Add(nums[0]);
                return;
            }

            var key = string.Join("", nums);
            //var key = nums.GetHashCode();
            if (!memoize.ContainsKey(key))
            {
                var sum = nums.Sum();
                memoize.Add(key, sum);
                sums.Add(sum);
            }

            int[] firstSubArray = new int[nums.Length - 1];
            Array.Copy(nums, 0, firstSubArray, 0, nums.Length - 1);
            int[] secondSubArray = new int[nums.Length - 1];
            Array.Copy(nums, 1, secondSubArray, 0, nums.Length - 1);

            if (!memoize.ContainsKey(string.Join("", firstSubArray)))
                GetSubArraySum(firstSubArray, sums, memoize);
            if (!memoize.ContainsKey(string.Join("", secondSubArray)))
                GetSubArraySum(secondSubArray, sums, memoize);
        }

        private static void GetSubArraySum(int[] nums, int low, int high, List<int> sums, Dictionary<string, int> memoize)
        {
            if (nums.Length == 1)
            {
                sums.Add(nums[0]);
                return;
            }

            string key = string.Concat(low, high);
            if (!memoize.ContainsKey(key))
            {
                int sum = 0;
                for (int i = low; i < high; i++)
                {
                    sum += nums[i];
                }
                memoize.Add(key, sum);
                sums.Add(sum);
            }

            if (!memoize.ContainsKey(string.Concat(low, high - 1)))
                GetSubArraySum(nums, low, high - 1, sums, memoize);
            if (!memoize.ContainsKey(string.Concat(low + 1, high)))
                GetSubArraySum(nums, low + 1, high, sums, memoize);
        }

        private static void max_crossing_subarray(int[] nums, int low, int mid, int high, List<int> sums)
        {
            /*
              Initial left_sum should be -infinity.
              One can also use INT_MIN from limits.h
            */
            int left_sum = -1000000;
            int sum = 0;
            int i;

            /*
              iterating from middle
              element to the lowest element
              to find the maximum sum of the left
              subarray containing the middle
              element also.
            */
            for (i = mid; i >= low; i--)
            {
                sum = sum + nums[i];
                if (sum > left_sum)
                    left_sum = sum;
            }

            /*
              Similarly, finding the maximum
              sum of right subarray containing
              the adjacent right element to the
              middle element.
            */
            int right_sum = -1000000;
            sum = 0;

            for (i = mid + 1; i <= high; i++)
            {
                sum = sum + nums[i];
                if (sum > right_sum)
                    right_sum = sum;
            }

            /*
              returning the maximum sum of the subarray
              containing the middle element.
            */
            sums.Add(left_sum + right_sum);
        }


        #endregion

        #region Rotate Image

        public static void Rotate(int[,] matrix)
        {
            int temp;
            int i = 0;
            int j = matrix.GetLength(0) - 1;
            int k = 0;

            for (int c = matrix.GetLength(0) - 1; c > 0; c = c - 2)
            {
                for (int e = c; e > 0; e--)
                {
                    temp = matrix[i - k, i];
                    matrix[i - k, i] = matrix[j, i - k];
                    matrix[j, i - k] = matrix[j + k, j];
                    matrix[j + k, j] = matrix[i, j + k];
                    matrix[i, j + k] = temp;

                    k++;
                    i++;
                    j--;
                }

                k = 0;
                i = 1;
                j = c - 1;
            }
        }

        #endregion

        #region Validate Soduku

        //public static bool IsValidSudoku(char[,] board)
        //{
        //    char s;
        //    int r;
        //    for (int k = 0; k < 9; k++)
        //    {
        //        for (int i = 0; i < 9; i++)
        //        {
        //            s = board[k, i];

        //            if (s == '.')
        //            {
        //                continue;
        //            }
        //            else
        //            {
        //                int j = i + 1;
        //                while (j < 9)
        //                {
        //                    if (board[k, j] == '.')
        //                    {
        //                        j++;
        //                        continue;
        //                    }
        //                    if (board[k, j] == s)
        //                        return false;
        //                    else
        //                    {
        //                        j++;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return true;
        //}

        //public static bool IsValidSudoku(char[,] board)
        //{
        //    // validate rows
        //    char s;
        //    int j;

        //    for (int k = 0; k < 9; k++)
        //    {
        //        for (int i = 0; i < 9; i++)
        //        {
        //            j = i;
        //            s = board[k, j];
        //            j = i + 1;

        //            if (s == '.') continue;

        //            while (j < 9)
        //            {
        //                if (board[i, j] == '.')
        //                {
        //                    j++;
        //                    continue;
        //                }
        //                if (board[i, j] == s)
        //                    return false;
        //                else
        //                {
        //                    j++;
        //                }
        //            }
        //        } 
        //    }

        //    return true;
        //}

        #endregion

        #region Two Sum

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;
        }

        public int[] TwoSum1(int[] nums, int target)
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

        #endregion

        #region Move Zeros

        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1) return;
            int i = 0;

            int k = nums.Length;

            while (true)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < k; j++)
                    {
                        if (j < nums.Length - 1)
                            nums[j] = nums[j + 1];
                    }

                    k--;

                    nums[nums.Length - 1] = 0;
                }
                else
                {
                    i++;
                }

                if (k == 0 || i >= nums.Length)
                    break;
            }
        }

        #endregion

        #region PlusOne

        /// <summary>
        ///  The logic is to add 1 to last digit. if sum is 10 then increament the next digit and return.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int[] PlusOne(int[] digits)
        {
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            var t = new int[digits.Length + 1];
            t[0] = 1;
            return t;
        }

       #endregion

        #region Array Intersection

        // the logic is to find the common elements and prepare the result
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();

            if (nums1.Length == 0 || nums2.Length == 0) return result.ToArray();

            List<int> indexes = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (indexes.Contains(j))
                        continue;

                    if (nums1[i] == nums2[j])
                    {
                        indexes.Add(j);
                        break;
                    }
                }
            }

            for (int i = 0; i < indexes.Count; i++)
            {
                result.Add(nums2[indexes[i]]);
            }

            return result.ToArray();
        }

        #endregion

        #region Single number

        /// <summary>
        /// XOR solution where same number whne XOR together result in 0
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumber(int[] nums)
        {
            if (nums.Length == 0) return -1;
            int number = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                number = number ^ nums[i];
            }

            return number;
        }

        #endregion

        #region Contains Duplicate
        /// <summary>
        /// sort the array and checked for duplicate
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length < 2) return false;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1 && nums[i] == nums[i + 1])
                    return true;
            }

            return false;
        }

        #endregion

        #region rotate array
        public static void Rotate(int[] nums, int k)
        {
            int temp;
            for (int i = 0; i < k; i++)
            {
                temp = nums[nums.Length - 1];

                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }

                nums[0] = temp;
            }
        }

        //public static void Rotate(int[] nums, int k)
        //{
        //    for (int i = 0; i < k; i++)
        //    {
        //        int temp;
        //        for (int j = nums.Length - 1; j > 0; j--)
        //        {
        //            temp = nums[j - 1];
        //            nums[j - 1] = nums[j];
        //            nums[j] = temp;
        //        }
        //    }
        //} 
        #endregion

        #region Max Profit

        /// <summary>
        ///  The logic is search for first min value and substract it with next max value (number before another smaller number)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) return 0; // Can not buy and sell.

            int profit = 0;
            int mIndex = -1;
            int minValue;
            int maxIndex = -1;
            int maxValue;
            int k = 0;

            while (true)
            {
                minValue = int.MaxValue;
                // find the minimum value index
                for (int i = k; i < prices.Length; i++)
                {
                    if (minValue > prices[i])
                    {
                        minValue = prices[i];
                        mIndex = i;
                    }

                    if ((i + 1) < prices.Length && minValue < prices[i + 1])
                        break;
                }

                maxValue = minValue;
                for (int i = mIndex + 1; i < prices.Length; i++)
                {
                    if (prices[i] > maxValue)
                    {
                        maxValue = prices[i];
                        maxIndex = i;
                    }

                    if ((i + 1) < prices.Length && maxValue > prices[i + 1])
                        break;
                }

                if (mIndex < maxIndex)
                    profit = profit + (prices[maxIndex] - prices[mIndex]);
                else
                    break;

                k = maxIndex + 1;

                if (maxIndex >= prices.Length - 1) break;
            }

            return profit;
        }
        #endregion

        #region remove duplicates
        /// <summary>
        /// The logic is to move the distinct characters in the begining and than resizing the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int element = nums[0];
            int dc = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == element)
                {
                    dc++;
                    i++;
                    nums[i] = nums[i];
                    element = nums[i];
                }
            }

            int newLength = nums.Length - dc;
            Array.Resize(ref nums, newLength);

            return nums.Length;
        }

        //public static int RemoveDuplicates(int[] nums)
        //{
        //    if (nums.Length == 0) return 0;
        //    int element = nums[0];
        //    List<int> indexes = new List<int>();

        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        if (nums[i] == element)
        //        {
        //            indexes.Add(i);                   
        //        }
        //        element = nums[i];
        //    }

        //    int numIndex = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (!indexes.Contains(i))
        //        {
        //            nums[numIndex] = nums[i];
        //            numIndex++;
        //        }
        //    }

        //    int newLength = nums.Length - indexes.Count;
        //    Array.Resize(ref nums, newLength);

        //    return nums.Length;
        //} 
        #endregion
    }
}
