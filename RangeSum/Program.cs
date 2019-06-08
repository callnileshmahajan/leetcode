using System;
using System.Collections.Generic;

namespace RangeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // var result = RangeSumBST(PrepareBinaryTree(), 7, 15);
            var result = TrimBST(PrepareBinaryTree(), 2, 4);
            Console.WriteLine(result);
            Console.Read();
        }

        private static int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;
            TraverseInOrder(root, L, R, ref sum);

            return sum;
        }

        private static void TraverseInOrder(TreeNode root, int l, int r, ref int sum)
        {
            if(root == null) return;

            sum += TraverseRoot(root, l, r);

            if (root.val >= l)
            {
                TraverseInOrder(root.left, l, r, ref sum);
            }

            if (root.val <= r)
            {
                TraverseInOrder(root.right, l, r, ref sum);
            }            
        }

        private static int TraverseRoot(TreeNode node, int l, int r)
        {
            return GetNodeValue(node, l, r);
        }

        private static int GetNodeValue(TreeNode node, int l, int r)
        {
            if (node.val >= l && node.val <= r)
                return node.val;
            else
                return 0;
        }

        //private static TreeNode PrepareBinaryTree()
        //{
        //    TreeNode root = new TreeNode(10);
        //    root.left = new TreeNode(5);
        //    root.left.left = new TreeNode(3);
        //    root.left.right = new TreeNode(7);

        //    root.right = new TreeNode(15);
        //    root.right.left = null;
        //    root.right.right = new TreeNode(18);

        //    return root;
        //}

        private static TreeNode PrepareBinaryTree()
        {
            //TreeNode root = new TreeNode(3);
            //root.left = new TreeNode(0);
            //root.right = new TreeNode(4);

            //root.left.left = null;
            //root.left.right = new TreeNode(2);
            //root.left.right.left = new TreeNode(1);
            //root.left.right.right = null;

            //root.right.left = null;
            //root.right.right = null;

            TreeNode root = new TreeNode(1);
            root.left = null;
            root.right = new TreeNode(2);

            //root.left.left = null;
            //root.left.right = new TreeNode(2);
            //root.left.right.left = new TreeNode(1);
            //root.left.right.right = null;

            //root.right.left = null;
            //root.right.right = null;

            return root;
        }

        //------------------------------------------------------------
        //private static TreeNode TrimBST(TreeNode root, int L, int R)
        //{
        //    var result = TraverseInOrder(root, L, R);

        //    if (result)
        //    {
        //        if (root.left != null)
        //            root = root.left;
        //        else if (root.right != null)
        //            root = root.right;
        //        else
        //            root = null;
        //    }

        //    return root;
        //}

        private static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null) return root;
            if (root.val > R) return TrimBST(root.left, L, R);
            if (root.val < L) return TrimBST(root.right, L, R);

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);
            return root;
        }

        private static bool TraverseInOrder(TreeNode root, int l, int r)
        {
            if (root == null) return false;

            bool deleteLeft = false;
            bool deleteRight = false;

            bool shouldDelete = TraverseRootTrim(root, l, r);
            
            if (root.val >= l)
            {
                deleteLeft = TraverseInOrder(root.left, l, r);
            }
            else
            {
                root.left = null;
            }
            
            if (root.val <= r)
            {
                deleteRight = TraverseInOrder(root.right, l, r); 
            }
            else
            {
                root.right = null;
            }

            if (deleteLeft)
            {
                if (root.left.left != null)
                    root.left = root.left.left;
                else if (root.left.right != null)
                    root.left = root.left.right;
                else
                    root.left = null;
            }

            if (deleteRight)
            {
                if (root.right.right != null)
                    root.right = root.right.right;
                else if (root.right.left != null)
                    root.right = root.right.left;
                else
                    root.right = null;
            }

            return shouldDelete;
        }
       
        private static bool TraverseRootTrim(TreeNode node, int l, int r)
        {
            return !(node.val >= l && node.val <= r);
        }
    }

    public class TreeNode
    {
        public int val;

        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x) { val = x; }
    }
}
