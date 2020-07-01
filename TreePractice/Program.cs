using System;
using System.Collections.Generic;

namespace TreePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //TreeNode root = new TreeNode(5);
            //var leftonde = new TreeNode(3);
            //var rightNode = new TreeNode(6);

            //root.left = leftonde;
            //root.right = rightNode;

            //leftonde.left = new TreeNode(2);
            //leftonde.right = new TreeNode(4);

            //leftonde.left.left = new TreeNode(1);

            //rightNode.left = new TreeNode(7);
            //rightNode.right = new TreeNode(9);
            //------------------------------------------------
            TreeNode root = new TreeNode(1);
            var rightNode = new TreeNode(2);

            root.left = null;
            root.right = rightNode;

            //rightNode.left = new TreeNode(3);
            //rightNode.right = null;


            var result = RightSideView(root);
            
            Console.Read();
        }
        //

        #region Rigth side view

        /// <summary>
        /// My solution is correct but actual in leet code it was expected to be traversed in Pre Order traversal.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> RightSideView(TreeNode root)
        {
            if (root == null) return new List<int>();
            if (root.right == null) return new List<int> { root.val };

            List<int> rights = new List<int>();
            rights.Add(root.val);

            root = root.right;

            while (root != null)
            {
                rights.Add(root.val);
                root = root.right;
            }

            return rights;
        }

        #endregion

        #region kthSmallest traversal
        /// <summary>
        /// The logic is to put the items in the stack. And this should be done by traversing the left subtree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int KthSmallestwithStack(TreeNode root, int k)
        {
            var stack = new Stack<TreeNode>();

            while (true)
            {
                // Move to left leaf node and put it to stack.
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                if (--k == 0)
                    return root.val;

                root = root.right;
            }
        }

        // Logic is to traverse the tree in InOrder traversal and search for Kth element.
        public static int KthSmallest(TreeNode root, int k)
        {
            List<int> traversedNode = new List<int>();
            InOrderTraversalHelper(root, traversedNode);

            if (traversedNode != null && traversedNode.Count >= k)
                return traversedNode[k - 1]; // Zero based index.

            return root.val;
        }

        #endregion

        #region  In order traversal
        public static IList<int> InorderTraversal(TreeNode root)
        {
            List<int> traversedNode = new List<int>();

            InOrderTraversalHelper(root, traversedNode);

            return traversedNode;
        }

        private static void InOrderTraversalHelper(TreeNode currentNode, List<int> traversedNode)
        {
            if (currentNode == null) return;

            InOrderTraversalHelper(currentNode.left, traversedNode);

            if (currentNode != null)
            {
                traversedNode.Add(currentNode.val);
            }

            InOrderTraversalHelper(currentNode.right, traversedNode);
        } 
        #endregion
    }

    /// <summary>
    /// the logic is to initialize the a queue via inorder traversal and then use the queue for iterator.
    /// </summary>
    public class BSTIterator
    {
        Queue<int> _traversedTree;
        public BSTIterator(TreeNode root)
        {
             _traversedTree = InorderTraversal(root);
        }

        /** @return the next smallest number */
        public int Next()
        {
            if (_traversedTree.Count > 0)
                return _traversedTree.Dequeue();

            return int.MinValue;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return _traversedTree.Count > 0;
        }

        private Queue<int> InorderTraversal(TreeNode root)
        {
            Queue<int> traversedNode = new Queue<int>();

            InOrderTraversalHelper(root, traversedNode);

            return traversedNode;
        }

        private void InOrderTraversalHelper(TreeNode currentNode, Queue<int> traversedNode)
        {
            if (currentNode == null) return;

            InOrderTraversalHelper(currentNode.left, traversedNode);

            if (currentNode != null)
            {
                traversedNode.Enqueue(currentNode.val);
            }

            InOrderTraversalHelper(currentNode.right, traversedNode);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
