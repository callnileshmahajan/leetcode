using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 1, 6, 0, 5 };

            var result = ConstructMaximumBinaryTree(nums);
            Console.Read();
        }

        private static TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            if (nums.Length == 0) return null;

            return MaximumBSTHelper(nums, 0, nums.Length - 1);
        }

        private static TreeNode MaximumBSTHelper(int[] nums, int s, int e)
        {
            if (s < 0 || s >= nums.Length) return null;
            if (e - s < 0) return null; // Only one element left in the array.

            int maxIndex = FindMaximum(nums, s, e);

            TreeNode root = new TreeNode(nums[maxIndex]);

            root.left = MaximumBSTHelper(nums, s, maxIndex - 1);
            root.right = MaximumBSTHelper(nums, maxIndex + 1, e);

            return root;

        }

        private static int FindMaximum(int[] nums, int s, int e)
        {
            int max = int.MinValue;
            int maxIndex = -1;

            for (int i = s; i <= e; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;

                }
            }

            return maxIndex;
        }
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int x) { val = x; }
}

