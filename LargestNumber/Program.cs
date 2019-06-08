using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int[] nums = new int[] { 3, 30, 34, 5, 9 };
            int[] nums = new int[] { 74, 21, 33, 51, 77, 51, 90, 60, 5, 56 };
            //[1,2,4,8,16,32,64,128,256,512]
            //[74,21,33,51,77,51,90,60,5,56]
            LargestNumber(nums);
            Console.Read();
        }

        public static string LargestNumber(int[] nums)
        {
            string[] arrayNum = new string[nums.Length];

            int zeroCounter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) zeroCounter++;
                arrayNum[i] = nums[i].ToString();
            }

            if (zeroCounter == nums.Length) return "0";

            Array.Sort(arrayNum, new LargerNumberComparator());

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arrayNum.Length; i++)
            {
                    sb.Append(arrayNum[i]);
            }           

            return sb.ToString();
        }

        private class LargerNumberComparator : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                string order1 = x + y;
                string order2 = y + x;
                return order2.CompareTo(order1);
            }
        }
    }
}
