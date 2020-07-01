using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSome
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] nums = new int[] { -2, 0, 1, 1, 2 };
            var result = ThreeSum(nums);
            Console.Read();
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var resultSet = new List<IList<int>>();
            Dictionary<string, List<int>> dicResult = new Dictionary<string, List<int>>();
            nums = nums.OrderBy(n => n).ToArray();

            if (nums.Length == 0) return resultSet;
            if (nums.Length <= 2 && nums[0] == 0) return resultSet;
            if (nums[0] > 0) return resultSet;
            if (nums[0] == 0 && nums[nums.Length - 1] == 0)
            {
                var tempList = new List<int> { 0, 0, 0 };
                resultSet.Add(tempList);
                return resultSet;
            }
            int lastIndex;
            int firstIndex;
            int sum;

            for (int numIndex = 0; numIndex < nums.Length; numIndex++)
            {
                lastIndex = nums.Length - 1;
                firstIndex = numIndex + 1;
                while (lastIndex > firstIndex)
                {
                    sum = nums[numIndex] + nums[firstIndex] + nums[lastIndex];

                    if (sum == 0)
                    {
                        var tempList = new List<int>
                            {
                            nums[numIndex],
                            nums[firstIndex],
                            nums[lastIndex]
                            };

                        tempList.Sort();

                        var key = string.Concat(tempList[0], ',', tempList[1], ',', tempList[2]);

                        if (!dicResult.ContainsKey(string.Concat(key)))
                        {
                            dicResult.Add(key, tempList);
                        }
                        lastIndex--;
                        firstIndex++;
                    }
                    else if (sum < 0)
                    {
                        firstIndex++;
                    }
                    else if (sum > 0)
                    {
                        lastIndex--;
                    }
                }
            }

            foreach (var key in dicResult.Keys)
            {
                resultSet.Add(dicResult[key]);
            }

            return resultSet;
        }

        //public static IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    var resultSet = new List<IList<int>>();
        //    Dictionary<string, List<int>> dicResult = new Dictionary<string, List<int>>();
        //    nums = nums.OrderBy(n => n).ToArray();

        //    if (nums.Length == 0) return resultSet;
        //    if (nums.Length <= 2 && nums[0] == 0) return resultSet;
        //    if (nums[0] > 0) return resultSet;
        //    if (nums[0] == 0 && nums[nums.Length - 1] == 0)
        //    {
        //        var tempList = new List<int> { 0, 0, 0 };
        //        resultSet.Add(tempList);
        //        return resultSet;
        //    }

        //    int lastIndex;
        //    int firstIndex;
        //    int sum;

        //    for (int numIndex = 0; numIndex < nums.Length; numIndex++)
        //    {
        //        lastIndex = nums.Length - 1;
        //        firstIndex = numIndex + 1;
        //        while (lastIndex > firstIndex)
        //        {
        //            sum = nums[numIndex] + nums[firstIndex] + nums[lastIndex];

        //            if (sum == 0)
        //            {
        //                var tempList = new List<int>
        //                    {
        //                    nums[numIndex],
        //                    nums[firstIndex],
        //                    nums[lastIndex]
        //                    };

        //                tempList.Sort();

        //                var key = string.Concat(tempList[0], ',', tempList[1], ',', tempList[2]);

        //                if (!dicResult.ContainsKey(string.Concat(key)))
        //                {
        //                    dicResult.Add(key, tempList);
        //                }

        //                lastIndex--;
        //                firstIndex++;
        //            }
        //            else if (sum < 0)
        //                firstIndex++;
        //            else if (sum > 0)
        //                lastIndex--;
        //        }
        //    }

        //    foreach (var key in dicResult.Keys)
        //    {
        //        resultSet.Add(dicResult[key]);
        //    }

        //    return resultSet;
        //}

        // Time limit exceeded
        //public static IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    var resultSet = new List<IList<int>>();
        //    Dictionary<string, List<int>> dicResult = new Dictionary<string, List<int>>();
        //    nums = nums.OrderBy(n => n).ToArray();

        //    if (nums[0] > 0) return resultSet;

        //    int lastIndex = nums.Length - 1;
        //    int numIndex = 0;
        //    int sum;

        //    while (nums[numIndex] <= 0)
        //    {
        //        lastIndex = nums.Length - 1;
        //        while (nums[lastIndex] >= 0)
        //        {
        //            int internalIndex = lastIndex - 1;
        //            while (nums[internalIndex] >= 0)
        //            {
        //                sum = nums[numIndex] + nums[lastIndex] + nums[internalIndex];
        //                if (sum == 0)
        //                {
        //                    var tempList = new List<int>
        //                    {
        //                    nums[numIndex],
        //                    nums[lastIndex],
        //                    nums[internalIndex]
        //                    };

        //                    tempList.Sort();

        //                    var key = string.Concat(tempList[0], ',', tempList[1], ',', tempList[2]);

        //                    if (!dicResult.ContainsKey(string.Concat(key)))
        //                    {
        //                        dicResult.Add(key, tempList);
        //                    }
        //                    break;
        //                }

        //                internalIndex--;
        //            }

        //            lastIndex--;
        //        }

        //        numIndex++;
        //    }

        //    foreach (var key in dicResult.Keys)
        //    {
        //        resultSet.Add(dicResult[key]);
        //    }

        //    return resultSet;
        //}

        //private static int ThreeSumHelper(int[] nums, int index)
        //{
        //    return nums[index] + nums[index - 1];
        //}

        // NOTE: Time limit exceeded
        //public static IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    var resultSet = new List<IList<int>>();
        //    Dictionary<string, List<int>> dicResult = new Dictionary<string, List<int>>();
        //    int nextIndex;

        //    for (int arrayIndex = 0; arrayIndex < nums.Length; arrayIndex++)
        //    {
        //        nextIndex = arrayIndex + 1;

        //        while (nextIndex <= nums.Length - 1)
        //        {
        //            for (int index = nextIndex + 1; index < nums.Length; index++)
        //            {
        //                if (CalculateSum(nums, arrayIndex, nextIndex, index))
        //                {
        //var tempList = new List<int>
        //                {
        //                    nums[arrayIndex],
        //                    nums[nextIndex],
        //                    nums[index]
        //                };

        //tempList.Sort();

        //                    var key = string.Concat(tempList[0], ',', tempList[1], ',', tempList[2]);

        //                    if (!dicResult.ContainsKey(string.Concat(key)))
        //                    {
        //                        dicResult.Add(key, tempList);
        //                    }
        //                }
        //            }

        //            nextIndex++; 
        //        }
        //    }

        //    foreach (var key in dicResult.Keys)
        //    {
        //        resultSet.Add(dicResult[key]);
        //    }

        //    return resultSet;
        //}
    }
}
