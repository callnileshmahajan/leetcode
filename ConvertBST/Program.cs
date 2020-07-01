using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBST
{
    class Program
    {
        static void Main(string[] args)
        {
            //TreeNode root = new TreeNode(6);
            //var leftonde = new TreeNode(2);
            //var rightNode = new TreeNode(8);

            //root.left = leftonde;
            //root.right = rightNode;

            //leftonde.left = new TreeNode(0);
            //leftonde.right = new TreeNode(4);

            //leftonde.right.left = new TreeNode(3);
            //leftonde.right.right = new TreeNode(5);

            //rightNode.left = new TreeNode(7);
            //rightNode.right = new TreeNode(9);

            TreeNode root = new TreeNode(2);
            var leftonde = new TreeNode(1);

            root.left = leftonde;
            root.right = null;       

            LowestCommonAncestor(root, new TreeNode(2), new TreeNode(1));

            Console.Read();
        }


        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root.val > p.val && root.val > q.val)
                return LowestCommonAncestor(root.left, p, q);
            else if (root.val < p.val && root.val < q.val)
                return LowestCommonAncestor(root.right, p, q);
            else
                return root;
        }


        //public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    var pathToFirstNode = PathToGivenNode(root, p);
        //    var pathToSecondNode = PathToGivenNode(root, q);

        //    int index = 0;

        //    while (index < pathToFirstNode.Count && index < pathToSecondNode.Count && pathToFirstNode[index].val == pathToSecondNode[index].val)
        //    {
        //        index++;
        //    }

        //    index--;
        //    return pathToFirstNode[index];
        //}

        //private static List<TreeNode> PathToGivenNode(TreeNode root, TreeNode p)
        //{
        //    List<TreeNode> treeNodes = new List<TreeNode>();

        //    while (root.val != p.val)
        //    {
        //        treeNodes.Add(root);
        //        if (p.val < root.val) // left Subtree
        //        {                    
        //            root = root.left;
        //        }
        //        else
        //        {
        //            root = root.right;
        //        }
        //    }

        //    if (root.val == p.val)
        //        treeNodes.Add(root);

        //    return treeNodes;
        //}
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
