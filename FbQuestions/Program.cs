using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace FbQuestions
{
    public class WIndex
    {
        public int Index;
        public int Weight;
        public int ActualWeight;
    }

    class Program
    {
        static Queue<WIndex> wIdx = new Queue<WIndex>();

        static void Main(string[] args)
        {
            string[][] matrix = new string[4][];
            matrix[0] = new string[3] { "John", "johnsmith@mail.com", "john00@mail.com" };
            matrix[1] = new string[2] { "John", "johnnybravo@mail.com" };
            matrix[2] = new string[3] { "John", "johnsmith@mail.com", "john_newyork@mail.com" };
            matrix[3] = new string[2] { "Mary", "mary@mail.com" };
            //---------------------------------------------
            int[][] image = new int[2][];
            image[0] = new int[3] { 0, 0, 0 };
            image[1] = new int[3] { 0, 0, 0 };
            //image[2] = new int[3] { 1, 0, 1 };

            //int[,] m = new int[4, 4]
            //{
            //    {0,10,12,0 },
            //    { 1,0,2,0},
            //    {0,0,0,0 },
            //     {0,0,0,0 }
            //};

            //int[,] n = new int[4, 4]
            //{
            //    {2,5,0,0 },
            //    { 0,1,0,0},
            //    {8,0,0,0 },
            //     {0,0,0,0 }
            //};

            //int[] nums = new int[] { 1,2,3 };
            //CheckSubarraySum(nums,6);

            //string[] logs = new string[] { "0:start:0", "0:start:2", "0:end:5", "0:start:6", "0:end:6", "0:end:7" };
            //string[] logs = new string[] { "0:start:0", "1:start:2", "1:end:5", "0:end:6" };
            // var result = FloodFill(image, 0, 0, 2);

            TreeNode root = new TreeNode(1);
            var leftnode = new TreeNode(0);
            var rightnode = new TreeNode(1);

            root.left = leftnode;
            root.right = rightnode;

            leftnode.left = new TreeNode(0);
            leftnode.right = new TreeNode(1);

            rightnode.left = new TreeNode(0);
            rightnode.right = new TreeNode(1);


            int[] nums = new int[] { -4, -1, 0, 3, 10 };
            string s = "ymbgaraibkfmvocpizdydugvalagaivdbfsfbepeyccqfepzvtpyxtbadkhmwmoswrcxnargtlswqemafandgkmydtimuzvjwxvlfwlhvkrgcsithaqlcvrihrwqkpjdhgfgreqoxzfvhjzojhghfwbvpfzectwwhexthbsndovxejsntmjihchaotbgcysfdaojkjldprwyrnischrgmtvjcorypvopfmegizfkvudubnejzfqffvgdoxohuinkyygbdzmshvyqyhsozwvlhevfepdvafgkqpkmcsikfyxczcovrmwqxxbnhfzcjjcpgzjjfateajnnvlbwhyppdleahgaypxidkpwmfqwqyofwdqgxhjaxvyrzupfwesmxbjszolgwqvfiozofncbohduqgiswuiyddmwlwubetyaummenkdfptjczxemryuotrrymrfdxtrebpbjtpnuhsbnovhectpjhfhahbqrfbyxggobsweefcwxpqsspyssrmdhuelkkvyjxswjwofngpwfxvknkjviiavorwyfzlnktmfwxkvwkrwdcxjfzikdyswsuxegmhtnxjraqrdchaauazfhtklxsksbhwgjphgbasfnlwqwukprgvihntsyymdrfovaszjywuqygpvjtvlsvvqbvzsmgweiayhlubnbsitvfxawhfmfiatxvqrcwjshvovxknnxnyyfexqycrlyksderlqarqhkxyaqwlwoqcribumrqjtelhwdvaiysgjlvksrfvjlcaiwrirtkkxbwgicyhvakxgdjwnwmubkiazdjkfmotglclqndqjxethoutvjchjbkoasnnfbgrnycucfpeovruguzumgmgddqwjgdvaujhyqsqtoexmnfuluaqbxoofvotvfoiexbnprrxptchmlctzgqtkivsilwgwgvpidpvasurraqfkcmxhdapjrlrnkbklwkrvoaziznlpor";
            string t = "qhxepbshlrhoecdaodgpousbzfcqjxulatciapuftffahhlmxbufgjuxstfjvljybfxnenlacmjqoymvamphpxnolwijwcecgwbcjhgdybfffwoygikvoecdggplfohemfypxfsvdrseyhmvkoovxhdvoavsqqbrsqrkqhbtmgwaurgisloqjixfwfvwtszcxwktkwesaxsmhsvlitegrlzkvfqoiiwxbzskzoewbkxtphapavbyvhzvgrrfriddnsrftfowhdanvhjvurhljmpxvpddxmzfgwwpkjrfgqptrmumoemhfpojnxzwlrxkcafvbhlwrapubhveattfifsmiounhqusvhywnxhwrgamgnesxmzliyzisqrwvkiyderyotxhwspqrrkeczjysfujvovsfcfouykcqyjoobfdgnlswfzjmyucaxuaslzwfnetekymrwbvponiaojdqnbmboldvvitamntwnyaeppjaohwkrisrlrgwcjqqgxeqerjrbapfzurcwxhcwzugcgnirkkrxdthtbmdqgvqxilllrsbwjhwqszrjtzyetwubdrlyakzxcveufvhqugyawvkivwonvmrgnchkzdysngqdibhkyboyftxcvvjoggecjsajbuqkjjxfvynrjsnvtfvgpgveycxidhhfauvjovmnbqgoxsafknluyimkczykwdgvqwlvvgdmufxdypwnajkncoynqticfetcdafvtqszuwfmrdggifokwmkgzuxnhncmnsstffqpqbplypapctctfhqpihavligbrutxmmygiyaklqtakdidvnvrjfteazeqmbgklrgrorudayokxptswwkcircwuhcavhdparjfkjypkyxhbgwxbkvpvrtzjaetahmxevmkhdfyidhrdeejapfbafwmdqjqszwnwzgclitdhlnkaiyldwkwwzvhyorgbysyjbxsspnjdewjxbhpsvj";
            int[] arr1 = new int[] { 28, 6,22,8,44,17};
            int[] arr2 = new int[] { 22,28,8,6 };

            var reuslt = SumRootToLeaf(root);
            Console.Read();
        }

        public static int SumRootToLeaf(TreeNode root)
        {
            List<string> nums = new List<string>();

            SumRootToLeaf(root, string.Empty, nums);
            int sum = 0;
            if (nums.Count > 0)
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    sum += Convert.ToInt32(nums[i], 2);
                }
            }

            return sum;
        }

        private static void SumRootToLeaf(TreeNode node, string sb, List<string> nums)
        {
            if (node == null)
            {
                return;
            }

            sb = sb + node.val;

            if (node.left == null && node.right == null)
            {
                nums.Add(sb);
                return;
            }

            SumRootToLeaf(node.left, sb, nums);
            SumRootToLeaf(node.right, sb, nums);
        }

        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> valPos = new Dictionary<int, int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!valPos.ContainsKey(arr1[i]))
                    valPos.Add(arr1[i], 1);
                else
                    valPos[arr1[i]]++;
            }

            int a1 = 0;

            for (int j = 0; j < arr2.Length; j++)
            {
                if (valPos.ContainsKey(arr2[j]))
                {
                    for (int k = 0; k < valPos[arr2[j]]; k++)
                    {
                        arr1[a1++] = arr2[j];
                    }

                    valPos.Remove(arr2[j]);
                }
            }

            if (valPos.Keys.Count > 0) // Some values are left;
            {
                foreach (var keyval in valPos.OrderBy(key => key.Key))
                {
                    for (int k = 0; k < valPos[keyval.Key]; k++)
                        arr1[a1++] = keyval.Key;
                }
            }

            return arr1;
        }


        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> numPlace = new Dictionary<int, int>();
            for (int i = 0; i < nums2.Length; i++)
                numPlace.Add(nums2[i], i);

            List<int> result = new List<int>();

            for (int j = 0; j < nums1.Length; j++)
            {
                int nIx = numPlace.ContainsKey(nums1[j]) ? numPlace[nums1[j]] : -1;
                if (nIx != -1)
                {
                    int k;
                    for (k = nIx + 1; k < nums2.Length; k++)
                    {
                        if (nums2[k] > nums1[j])
                        {
                            result.Add(k);
                            break;
                        }


                        if (k == nums2.Length)
                            result.Add(-1);
                    }
                }

            }

            return result.ToArray();
        }

        public static bool FindTarget()
        {
            List<int> nVal = new List<int> { 2, 3 };
            for (int i = 0; i < nVal.Count; i++)
            {
                for (int j = 0; j < nVal.Count; j++)
                {
                    if (i == j) continue;
                    if (nVal[i] + nVal[j] == 6)
                        return true;
                }
            }

            return false;
        }

        private static bool FindTargetHelper(TreeNode node, int k)
        {
            if (node != null && node.left != null)
            {
                if (node.left.val + node.val == k)
                    return true;
                else
                    FindTargetHelper(node.left, k);
            }

            if (node != null && node.right != null)
            {
                if (node.right.val + node.val == k)
                    return true;
                else
                    FindTargetHelper(node.right, k);
            }

            return false;
        }

        public static char FindTheDifference(string s, string t)
        {
            var sa = s.ToCharArray();
            var ta = t.ToCharArray();
            Array.Sort(sa);
            Array.Sort(ta);

            int ia = 0;
            int ja = 0;

            while (ja < ta.Length)
            {
                if (ia < sa.Length && sa[ia] != ta[ja])
                    break;

                ja++;
                ia++;
            }

            return ta[ja - 1];
        }

        #region Max binary substring

        public static int CountBinarySubstrings(string s)
        {
            int cur = 1, pre = 0, res = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1]) cur++;
                else
                {
                    res += Math.Min(cur, pre);
                    pre = cur;
                    cur = 1;
                }
            }
            return res + Math.Min(cur, pre);
        }

        #endregion

        #region Unique Path
        /// <summary>
        /// Logic needs to understand.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int UniquePaths(int m, int n)
        {
            int[,] dp = new int[m + 1, n + 1];
            dp[m - 1, n - 1] = 1;

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (i == m - 1 && j == n - 1)
                        continue;

                    dp[i, j] = dp[i + 1, j] + dp[i, j + 1];
                }
            }

            return dp[0, 0];
        }

        #endregion

        #region Histogram Area

        /// <summary>
        /// The following logic is based on Stack where we push item to the stack till we encounter a larger value item. 
        /// if it happens, pop all the items which are greater than current value and calculate the area.
        /// if after one pass stack is not empty then calcuatle the area of the remaning items.
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public static int LargestRectangleArea1(int[] heights)
        {
            Stack<IndexValue> indexValues = new Stack<IndexValue>();
            int maxArea = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (indexValues.Count == 0)
                {
                    indexValues.Push(new IndexValue(i, heights[i]));
                    continue;
                }

                if (indexValues.Count > 0 && indexValues.Peek().Val > heights[i])
                {
                    int valCount = 1;
                    int lastIndex = -1;
                    while (indexValues.Count > 0 && indexValues.Peek().Val > heights[i])
                    {
                        var iv = indexValues.Pop();
                        lastIndex = iv.Index;
                        int area = iv.Val * valCount;
                        if (maxArea < area)
                            maxArea = area;

                        valCount++;
                    }

                    indexValues.Push(new IndexValue(lastIndex, heights[i]));
                }
                else
                {
                    indexValues.Push(new IndexValue(i, heights[i]));
                }
            }

            if (indexValues.Count > 0)
            {
                maxArea = GetMaxArea(indexValues, maxArea);
            }

            return maxArea;
        }

        private static int GetMaxArea(Stack<IndexValue> indexValues, int maxArea)
        {
            IndexValue temp = new IndexValue(0, 0);
            int maxIndex = indexValues.Peek().Index;
            int minValue = int.MaxValue;
            int minIndex = -1;

            while (indexValues.Count > 0)
            {
                temp = indexValues.Pop();
                if (minValue > temp.Val && temp.Val > 0)
                {
                    minIndex = temp.Index;
                    minValue = temp.Val;
                }
            }

            int area;

            if (temp.Val == 0)
                area = minValue * ((minIndex - minIndex) + 1);
            else
                area = temp.Val * ((maxIndex - temp.Index) + 1);

            if (area > maxArea)
                maxArea = area;

            return maxArea;
        }

        public struct IndexValue
        {
            public int Index;
            public int Val;

            public IndexValue(int index, int val)
            {
                Index = index;
                Val = val;
            }
        }

        /// <summary>
        /// its a brute force solution. It times out. For bigger array.
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public static int LargestRectangleArea(int[] heights)
        {
            if (heights.Length == 0) return 0;
            if (heights.Length == 1) return heights[0] * 1;

            HashSet<int> areas = new HashSet<int>();
            int arrSize = 0;

            while (arrSize < heights.Length)
            {
                arrSize++;

                for (int i = 0; i < heights.Length; i++)
                {
                    int minHeight = GetMinimumHeight(heights, i, arrSize);
                    int area = minHeight * arrSize;

                    if (!areas.Contains(area))
                        areas.Add(area);
                }
            }

            // Now find the max value in the hashset;

            int maxA = int.MinValue;
            foreach (var ar in areas)
            {
                if (ar > maxA)
                    maxA = ar;
            }

            return maxA;
        }

        private static int GetMinimumHeight(int[] heights, int i, int arrSize)
        {
            if (arrSize == 1) return heights[i];

            int min = int.MaxValue;

            for (int j = i; j < i + arrSize; j++)
            {
                if (j < heights.Length && heights[j] < min)
                    min = heights[j];
            }

            if (min == int.MaxValue || (i + arrSize) > heights.Length)
                min = 0;

            return min;
        }

        #endregion

        #region Decode Ways

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int NumDecodings(string s)
        {
            // Asusuming to fill the mapping later.
            HashSet<string> calResult = new HashSet<string>();

            if (s.Contains("0") && !s.Equals("10")) return 0;

            NumDecodingsHelper1(s, calResult);
            int count = s.Equals("10") ? 0 : 1;
            return calResult.Count() + count;
        }

        /// <summary>
        /// The logic is to add to hash set when either sigle digit or two digit less than 26.
        /// return count of hash set.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="calResult"></param>
        private static void NumDecodingsHelper(string s, HashSet<string> calResult)
        {
            if (s == "0") return;

            if ((s.Length == 1) || (s.Length == 2 && Convert.ToInt32(s) <= 26))
            {
                if (!calResult.Contains(s))
                    calResult.Add(s); // Already counted.
                else
                    return;
            }
            else if (s.Length == 2 && Convert.ToInt32(s) > 26)
                return;

            for (int i = 0; i < s.Length; i++)
            {
                NumDecodingsHelper(s.Substring(i, 1), calResult);

                if (i < s.Length - 1)
                    NumDecodingsHelper(s.Substring(i, 2), calResult);
            }
        }
        private static void NumDecodingsHelper1(string s, HashSet<string> calResult)
        {
            if (Convert.ToInt32(s) <= 9)
                return;

            if (s.Length == 2 && Convert.ToInt32(s) <= 26)
            {
                if (!calResult.Contains(s))
                    calResult.Add(s); // Already counted.
                else
                    return;
            }
            else if (s.Length == 2 && Convert.ToInt32(s) > 26)
                return;

            for (int i = 0; i < s.Length - 1; i++)
            {
                NumDecodingsHelper1(s.Substring(i, 2), calResult);
            }
        }

        #endregion

        #region Minimum Depth of a Binary search tree

        public static int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else if (root.left == null && root.right == null)
                return 1;

            return MinDepthHelper(root);
        }

        private static int MinDepthHelper(TreeNode node)
        {
            if (node == null) return 0;

            int lp = MinDepthHelper(node.left);
            int rp = MinDepthHelper(node.right);

            return Math.Min(lp, rp) + 1;
        }

        #endregion

        #region DecodeString

        /// <summary>
        /// The logic is to find the inner most [] and solve it first. Once decode replace it in original string. this is need to end the recursion.
        /// This can be done via recursion.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string DecodeString(string s)
        {
            if (s.Length == 0) return s;

            if (s.Length > 0 && (s.IndexOf('[') == -1 || s.IndexOf(']') == -1)) return s;

            while (s.IndexOf('[') != -1 || s.IndexOf(']') != -1)
            {
                int idxOp = s.LastIndexOf('[');
                int idxC = s.IndexOf(']', idxOp);
                int exIdx = idxOp;
                int j = 1;
                while (idxOp - ++j >= 0 && char.IsDigit(s[idxOp - j]))
                    exIdx--;

                int exp = Convert.ToInt32(s.Substring(exIdx - 1, (idxOp - exIdx + 1)));
                string subStr = s.Substring(exIdx - 1, (idxC - exIdx + 2));
                string result = DecodeString(s.Substring(idxOp + 1, (idxC - idxOp - 1)));

                StringBuilder temp = new StringBuilder();
                for (int i = 0; i < exp; i++)
                {
                    temp.Append(result);
                }

                s = s.Replace(subStr, temp.ToString());
            }

            return s;
        }


        //public static string DecodeString(string s)
        //{
        //    if (string.IsNullOrEmpty(s)) return s;

        //    Stack<char> ds = new Stack<char>();
        //    StringBuilder decodeString = new StringBuilder();
        //    bool pExp = false;

        //    foreach (var ch in s)
        //    {
        //        if (ch != ']')
        //        {
        //            ds.Push(ch);
        //            pExp = true;
        //        }
        //        else
        //        {
        //            string decStr = string.Empty;
        //            while (ds.Peek() != '[')
        //            {
        //                decStr = string.Concat(ds.Pop().ToString(), decStr);
        //            }

        //            ds.Pop(); // '['
        //            int r = ds.Pop() - '0';

        //            if (!pExp)
        //            {
        //                decStr = string.Concat(decStr, decodeString.ToString());
        //                decodeString.Clear();
        //            }

        //            StringBuilder sb = new StringBuilder();
        //            for (int i = 0; i < r; i++)
        //            {
        //                sb.Append(decStr);
        //            }

        //             pExp = false;
        //            decodeString.Append(sb.ToString());
        //        }
        //    }

        //    return decodeString.ToString();
        //}

        #endregion

        #region Convert Ternary Expression to Binary Tree

        public static TreeNode<char> ConvertExpression(string s, int index)
        {
            if (index >= s.Length)
                return null;

            TreeNode<char> root = new TreeNode<char>(s[index]);

            ++index;

            if (index < s.Length && s[index] == '?')
            {
                root.left = ConvertExpression(s, index + 1);
            }

            if (index < s.Length)
            {
                root.right = ConvertExpression(s, index + 1);
            }

            return root;
        }


        public static TreeNode<char> TernaryExpToBinaryTree(string s)
        {
            if (string.IsNullOrEmpty(s)) return null;

            TreeNode<char> root = null;
            bool left = false;
            bool right = false;
            Stack<TreeNode<char>> pNode = new Stack<TreeNode<char>>();

            foreach (var ch in s)
            {
                if (root == null)
                {
                    root = new TreeNode<char>(ch);
                    continue;
                }

                if (ch == '?')
                    left = true;
                else if (ch == ':')
                    right = true;

                if (left)
                {
                    root.left = new TreeNode<char>(ch);
                    pNode.Push(root);
                    root = root.left;
                    left = false;
                }

                if (right)
                {
                    var pRoot = pNode.Pop();
                    pRoot.right = new TreeNode<char>(ch);
                    right = false;
                }
            }

            return root;
        }

        #endregion

        #region Max Interger value of a interger by replacing + *

        public static int MaxIntValue(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int result = 0;
            int pDigit = -1;
            foreach (var ch in s)
            {
                int digit = (ch - 48);

                if (digit == 0 || digit == 1)
                {
                    result = result + digit;
                    pDigit = digit;
                }
                else
                {
                    if (result == 0) result = 1;

                    if (pDigit == 1)
                        result = result + digit;
                    else
                        result = result * digit;

                    pDigit = digit;
                }
            }

            return result;
        }
        #endregion

        #region FloodFill

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="sr"></param>
        /// <param name="sc"></param>
        /// <param name="newColor"></param>
        /// <returns></returns>
        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] == newColor) return image;

            FillNewColor(image, sr, sc, image[sr][sc], newColor);

            return image;
        }
        private static void FillNewColor(int[][] image, int sr, int sc, int ccolor, int newColor)
        {
            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[sr].Length || image[sr][sc] != ccolor)
                return;

            image[sr][sc] = newColor;

            FillNewColor(image, sr + 1, sc, ccolor, newColor);
            FillNewColor(image, sr - 1, sc, ccolor, newColor);
            FillNewColor(image, sr, sc + 1, ccolor, newColor);
            FillNewColor(image, sr, sc - 1, ccolor, newColor);
        }


        //public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        //{
        //    int ccolor = image[sr][sc];

        //    Stack<string> filled = new Stack<string>();
        //    filled.Push(string.Concat(sr, ",", sc));

        //    while (filled.Count > 0)
        //    {
        //        var rowcol = filled.Pop().Split(',');

        //        sr = Convert.ToInt32(rowcol[0]);
        //        sc = Convert.ToInt32(rowcol[1]);

        //        image[sr][sc] = newColor;

        //        if (CanVisit(sr - 1, sc, image.GetLength(0), image[0].Length) && image[sr - 1][sc] == ccolor && image[sr - 1][sc] != newColor)
        //        {
        //            image[sr - 1][sc] = newColor;
        //            filled.Push(string.Concat(sr - 1, ",", sc));
        //        }

        //        if (CanVisit(sr + 1, sc, image.GetLength(0), image[0].Length) && image[sr + 1][sc] == ccolor && image[sr + 1][sc] != newColor)
        //        {
        //            image[sr + 1][sc] = newColor;
        //            filled.Push(string.Concat(sr + 1, ",", sc));
        //        }

        //        if (CanVisit(sr, sc - 1, image.GetLength(0), image[0].Length) && image[sr][sc - 1] == ccolor && image[sr][sc - 1] != newColor)
        //        {
        //            image[sr][sc - 1] = newColor;
        //            filled.Push(string.Concat(sr, ",", sc - 1));
        //        }

        //        if (CanVisit(sr, sc + 1, image.GetLength(0), image[0].Length) && image[sr][sc + 1] == ccolor && image[sr][sc + 1] != newColor)
        //        {
        //            image[sr][sc + 1] = newColor;
        //            filled.Push(string.Concat(sr, ",", sc + 1));
        //        }
        //    }

        //    return image;
        //}

        private static bool CanVisit(int sr, int sc, int rl, int cl)
        {
            if (sr >= 0 && sr < rl && sc >= 0 && sc < cl)
                return true;
            else
                return false;
        }
        #endregion

        #region Accounts Merge
        // Half code.
        public static IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            var emailToName = new Dictionary<string, string>();
            var graph = new Dictionary<string, List<string>>();

            int counter = 1;
            foreach (var account in accounts)
            {
                var name = string.Empty;

                foreach (var email in account)
                {
                    if (name == string.Empty)
                    {
                        name = email;
                        continue;
                    }

                    if (!graph.ContainsKey(email))
                    {
                        graph.Add(email, new List<string>());
                        graph[email].Add(account[counter]);
                    }

                    if (!graph.ContainsKey(account[counter]))
                    {
                        graph.Add(account[counter], new List<string>());
                        graph[account[counter]].Add(email);
                    }

                    emailToName.Add(email, name);
                    counter++;
                }
            }

            //foreach (var lst in accounts)
            //{
            //    for (int i = 1; i < accounts.Count; i++)
            //    {
            //        if (!emNaMap.ContainsKey(lst[i]))
            //            emNaMap.Add(lst[i], lst[0]);
            //    }
            //}

            //HashSet<string> seen = new HashSet<string>();
            //foreach (var acc in accounts)
            //{
            //    foreach (var email in acc)
            //    {
            //        if (!seen.Contains(email))
            //        {
            //            seen.Add(email);
            //            Stack<string> stack = new Stack<string>();
            //            stack.Push(email);

            //            List<string> component = new List<string>();

            //            while (stack.Count > 0)
            //            {
            //                string node = stack.Pop();
            //                component.Add(email);

            //            }
            //        } 
            //    }
            //}

            return null;
        }
        #endregion

        #region Is Bipartite Graph 
        const int BLUE = 0;
        const int GREEN = 1;
        const int NO_COLOR = -1;
        /// <summary>
        /// Bipartite means nodes of an edge should be different group.
        /// The following logic is to create a color map of having two colors one for each group and check if color of each node via BFS alogrithm.
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static bool IsBipartite(int[][] graph)
        {
            var colorMap = new Dictionary<int, int>();

            for (int i = 0; i < graph.Length; i++)
            {
                colorMap.Add(i, NO_COLOR);
            }

            for (int i = 0; i < graph.Length; i++)
            {
                if (colorMap[i] != NO_COLOR)
                    continue;

                if (!CheckBipartite(i, colorMap, graph))
                    return false;
            }

            return true;
        }
        private static bool CheckBipartite(int node, Dictionary<int, int> colorMap, int[][] graph)
        {
            Queue<int> bfsQ = new Queue<int>();
            bfsQ.Enqueue(node);
            HashSet<int> visisted = new HashSet<int>();

            while (bfsQ.Count > 0)
            {
                node = bfsQ.Dequeue();
                visisted.Add(node);
                int cc = colorMap[node];
                if (cc == NO_COLOR)
                    colorMap[node] = BLUE;

                int[] edges = graph[node];

                for (int j = 0; j < edges.Length; j++)
                {
                    if (colorMap[edges[j]] != NO_COLOR && colorMap[edges[j]] == colorMap[node])
                        return false;

                    if (colorMap[edges[j]] == NO_COLOR)
                    {
                        if (colorMap[node] == BLUE)
                            colorMap[edges[j]] = GREEN;
                        else
                            colorMap[edges[j]] = BLUE;
                    }

                    if (!visisted.Contains(edges[j]))
                    {
                        bfsQ.Enqueue(edges[j]);
                    }
                }
            }

            return true;
        }
        #endregion

        #region Reorganize String

        /// <summary>
        /// The logic is to put characters on the stack. take out one by one and append to a string builder.
        /// Heap solution is also there. where in two characters are taken out the same time.
        //        count letter appearance and store in hash[i]
        //find the letter with largest occurence.
        //put the letter into even index numbe(0, 2, 4 ...) char array
        //put the rest into the array
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string ReorganizeString(string S)
        {
            Stack<char> alph = new Stack<char>();
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            foreach (char ch in S)
            {
                counter++;
                if (alph.Count == 0 || sb.Length > 0 && sb[sb.Length - 1] == ch)
                {
                    alph.Push(ch);
                    continue;
                }

                if (alph.Peek() != ch)
                {
                    if (sb.Length > 0 && sb[sb.Length - 1] == alph.Peek())
                    {
                        sb.Append(ch);
                        sb.Append(alph.Pop());
                    }
                    else
                    {
                        sb.Append(alph.Pop());
                        sb.Append(ch);
                    }
                }
                else
                {
                    alph.Push(ch);
                }

                if (counter == S.Length && alph.Peek() != sb[sb.Length - 1]) // last character
                {
                    sb.Append(alph.Pop());
                }
            }

            counter = 0;
            while (counter < sb.Length)
            {
                if (alph.Count == 0) break;

                if ((alph.Peek() != sb[counter] && counter == 0) || (alph.Peek() != sb[counter] && (counter + 1 < sb.Length) && alph.Peek() != sb[counter + 1]))
                {
                    sb.Insert(counter, alph.Pop());
                }
                else if (alph.Peek() != sb[counter])
                {
                    sb.Append(alph.Pop());
                }

                counter++;
            }

            if (alph.Count > 0)
                return string.Empty;
            else
                return sb.ToString();
        }
        #endregion

        #region ExclusiveTime

        public static int[] ExclusiveTime(int n, IList<string> logs)
        {
            if (n == 0) return null;
            int[] result = new int[n];
            Stack<string> funcLogs = new Stack<string>();
            bool pEnded = false;
            int pEnd = -1;
            for (int i = 0; i < logs.Count; i++)
            {
                var log = logs[i].Split(':');

                if (log[1] == "start")
                {
                    if (funcLogs.Count > 0 && !pEnded)
                    {
                        var lg = funcLogs.Peek().Split(':');
                        int pStart = Convert.ToInt32(lg[2]);
                        int pfid = Convert.ToInt32(lg[0]);
                        result[pfid] = result[pfid] + Convert.ToInt32(log[2]) - pStart;
                    }
                    pEnded = false;
                    funcLogs.Push(logs[i]);
                }

                if (log[1] == "end")
                {
                    var lg = funcLogs.Pop().Split(':');
                    var fid = Convert.ToInt32(lg[0]);
                    if (fid.ToString() == log[0])
                    {
                        if (pEnd == -1)
                            result[fid] = result[fid] + (Convert.ToInt32(log[2]) - Convert.ToInt32(lg[2]) + 1);
                        else
                            result[fid] = result[fid] + (Convert.ToInt32(log[2]) - pEnd);
                    }

                    pEnd = Convert.ToInt32(log[2]);
                    pEnded = true;
                }
            }

            return result;
        }

        //  Stack could have been used. This solution is also ok;
        /// <summary>
        /// Exclusive Time of Functions
        /// </summary>
        /// <param name="n"></param>
        /// <param name="logs"></param>
        /// <returns></returns>
        //public static int[] ExclusiveTime(int n, IList<string> logs)
        //{
        //    if (n == 0) return null;

        //    Dictionary<string, string> funcTime = new Dictionary<string, string>();
        //    string cFid = string.Empty;
        //    string pFid = string.Empty;
        //    for (int i = 0; i < logs.Count; i++)
        //    {
        //        var lg = logs[i];
        //        var logD = lg.Split(':');

        //        if (cFid != logD[0])
        //        {
        //            pFid = cFid;
        //            cFid = logD[0];
        //        }

        //        if (!funcTime.ContainsKey(cFid))
        //        {
        //            funcTime.Add(cFid, lg);
        //        }

        //        if (!funcTime.ContainsKey(pFid))
        //        {
        //            // It may be that CPU had take the current PID again.
        //            pFid = cFid;
        //            continue;
        //        }

        //        //Assuming previous FID is already in dictionary
        //        var pld = funcTime[pFid].Split(':');
        //        int rt = Convert.ToInt32(logD[2]) - Convert.ToInt32(pld[2]) + Convert.ToInt32(funcTime[cFid].Split(':')[2]);
        //        pld[2] = rt.ToString();
        //        funcTime[pFid] = string.Join(":", pld);
        //    }

        //    List<int> result = new List<int>();
        //    foreach (var keyValue in funcTime)
        //    {
        //        var lv = funcTime[keyValue.Key].Split(':');
        //        result.Add(Convert.ToInt32(lv[2]));
        //    }

        //    return result.ToArray();
        //}
        #endregion

        #region Diameter of binary tree
        static int result = 0;
        /// <summary>
        /// The logic is to calculate the depth of left and right subtree then take max of left and right depth then add  1. 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            Depth(root);

            return result;
        }

        private static int Depth(TreeNode node)
        {
            if (node == null) return 0; // leaf node depth is zero.

            int ld = Depth(node.left);
            int rd = Depth(node.right);
            result = Math.Max(result, ld + rd);
            return Math.Max(ld, rd) + 1;
        }

        #endregion

        #region CheckSubarraySum

        /// <summary>
        /// The logic is to sum the first 2 element then 3 and so on till the solution is found.
        /// Two arrays
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool CheckSubarraySum(int[] nums, int k)
        {
            if (nums.Length <= 1) return false;

            int sas = 2;
            int sum = 0;

            if (nums.Length == 2)
            {
                sum = (nums[0] + nums[1]);
                var result = CheckMultipleOfK(sum, k);

                return result;
            }

            while (sas <= nums.Length - 1) // We should not consider full array
            {
                for (int i = 0; i < nums.Length - sas; i++)
                {
                    sum = GetSum(nums, i, sas);

                    if (CheckMultipleOfK(sum, k))
                        return true;

                    sum = GetSum(nums, i + 1, sas);

                    if (CheckMultipleOfK(sum, k))
                        return true;
                }

                sas++;
            }

            return false;
        }


        private static int GetSum(int[] nums, int i, int sas)
        {
            int sum = 0;
            for (int j = i; j < sas + i; j++)
            {
                sum = sum + nums[j];
            }

            return sum;
        }

        private static bool CheckMultipleOfK(int sum, int k)
        {
            if (sum == 0 && k == 0) return true;

            if (k != 0 && sum % k == 0)
                return true;

            return false;
        }

        #endregion

        #region Sort Color

        /// <summary>
        ///  Basic logic is to count the number of 0,1,2 in the array and replace them in the array in ascending order.
        ///  My logic partially correct. Need one more variable to correct.
        /// </summary>
        /// <param name="nums"></param>
        public static void SortColors(int[] nums)
        {
            int i = 0;
            int j = nums.Length - 1;

            int temp;

            while (i <= j)
            {
                if (nums[i] > nums[j])
                {
                    temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                    j--;
                }
                else
                    i++;
            }
        }
        #endregion

        #region Random Index by Weight

        private static void Initialize(int[] w)
        {
            for (int i = 0; i < w.Length; i++)
            {
                var wi = new WIndex();
                wi.Index = i;
                wi.Weight = w[i];
                wi.ActualWeight = w[i];
                wIdx.Enqueue(wi);
            }
        }

        public static int PickIndex()
        {

            var wi = wIdx.Peek();

            if (wi.Weight > 0)
            {
                wi.Weight = wi.Weight - 1;
                return wi.Index;
            }
            else
            {
                wi = wIdx.Dequeue();
                wi.Weight = wi.ActualWeight;
                wIdx.Enqueue(wi);

                wi = wIdx.Peek();
                wi.Weight = wi.Weight - 1;
                return wi.Index;
            }
        }

        #endregion

        #region Sparse Matrix Multiplication

        public static int[,] MutliplySparseMatrix(int[,] m, int[,] n)
        {
            int[,] result = new int[m.GetLength(0), n.GetLength(1)];
            int mVal;

            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < n.GetLength(1); col++)
                {
                    mVal = 0;

                    for (int mrow = 0; mrow < n.GetLength(0); mrow++)
                    {
                        mVal = mVal + (m[row, mrow] * n[mrow, col]);
                    }

                    result[row, col] = mVal;
                }
            }


            return result;
        }

        #endregion

        #region Transpose a Matrix

        public static void TransposeMatrix(int[,] m)
        {
            //int[,] trsp = new int[m.GetLength(1), m.GetLength(0)];
            int temp;
            HashSet<string> visited = new HashSet<string>();
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    if (row == col || visited.Contains(string.Concat(row, col))) continue;

                    temp = m[row, col];
                    m[row, col] = m[col, row];
                    m[col, row] = temp;

                    visited.Add(string.Concat(row, col));
                    visited.Add(string.Concat(col, row));
                }
            }
        }

        #endregion

        #region Expression Add Operators

        public static IList<string> AddOperators(string num, int target)
        {
            var memoization = new HashSet<string>();

            AddOperatorsHelper(num, char.MinValue, memoization, 0, string.Empty);

            List<string> result = new List<string>();

            // TODO: Need expression evaluator.
            //foreach (var key in memoization)
            //{
            //     // put evaluation code here.
            //   ./// Expression e = new Expression(key);
            //}

            return result;
        }

        /// <summary>
        /// Currently following method is just building expression for evaluation recursively.
        /// We need an expression evaluator from C# to completely solve the problem.
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="op"></param>
        /// <param name="memoization"></param>
        /// <param name="index"></param>
        /// <param name="currExpression"></param>
        private static void AddOperatorsHelper(string num, char op, HashSet<string> memoization, int index, string currExpression)
        {
            if (index == num.Length - 1)
            {
                currExpression = string.Concat(currExpression, op, num[index]);
                if (!memoization.Contains(currExpression))
                {
                    memoization.Add(currExpression);
                }
                return;
            }

            if (op == char.MinValue)
                currExpression = string.Concat(currExpression, num[index]);
            else
                currExpression = string.Concat(currExpression, op, num[index]);

            index++;

            AddOperatorsHelper(num, '*', memoization, index, currExpression);
            AddOperatorsHelper(num, '+', memoization, index, currExpression);
            AddOperatorsHelper(num, '-', memoization, index, currExpression);
        }


        /// Following solution does not take into operator precedence into account.
        //public static IList<string> AddOperators(string num, int target)
        //{
        //    var nums = num.ToArray();
        //    Dictionary<string, int> memoization = new Dictionary<string, int>();
        //    char[] op = new char[] { '+', '-', '*' };
        //    foreach (var digit in nums)
        //    {
        //        AddOperatorsHelper(CharToInt(digit), op, memoization);
        //    }

        //    List<string> result = new List<string>();

        //    foreach (var keyValue in memoization)
        //    {
        //        if(memoization[keyValue.Key] == target)
        //        {
        //            result.Add(keyValue.Key);
        //        }
        //    }

        //    return result;
        //}

        //private static void AddOperatorsHelper(int digit, char[] operators, Dictionary<string, int> memoization)
        //{
        //    if (memoization.Count == 0)
        //    {
        //        memoization.Add(digit.ToString(), digit);
        //        return;
        //    }
        //    else
        //    {

        //        int result;
        //        Dictionary<string, int> local = memoization.ToDictionary(entry => entry.Key,
        //                                       entry => entry.Value);

        //        foreach (var op in operators)
        //        {
        //            foreach (var keyValue in local)
        //            {
        //                var key = string.Concat(keyValue.Key, op, digit.ToString());

        //                if (memoization.ContainsKey(key)) return;

        //                if (op == '+')
        //                {
        //                    result = keyValue.Value + digit;
        //                    if (!memoization.ContainsKey(key))
        //                    {
        //                        memoization.Add(key, result);
        //                    }
        //                }
        //                if (op == '-')
        //                {
        //                    result = keyValue.Value - digit;
        //                    if (!memoization.ContainsKey(key))
        //                    {
        //                        memoization.Add(key, result);
        //                    }
        //                }
        //                if (op == '*')
        //                {
        //                    result = keyValue.Value * digit;
        //                    if (!memoization.ContainsKey(key))
        //                    {
        //                        memoization.Add(key, result);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}


        #endregion

        #region ProductExceptSelf


        /// The logic with division operator is by first calculating the product of all the digits and then dividing the product with ith digit to find the product except self.
        /// <summary>
        /// Initialize two empty arrays, L and R where for a given index i, L[i] would contain the product of all the numbers to the left of i and R[i] would contain the product of all the numbers to the right of i.
        // We would need two different loops to fill in values for the two arrays.For the array L, L[0]L[0] would be 1 since there are no elements to the left of the first element.For the rest of the elements, we simply use L[i] = L[i - 1] * nums[i - 1]L[i]= L[i−1]∗nums[i−1]. Remember that L[i] represents product of all the elements to the left of element at index i.
        //For the other array, we do the same thing but in reverse i.e.we start with the initial value of 1 in R[length - 1] R[length−1] where lengthlength is the number of elements in the array, and keep updating R[i] in reverse.Essentially, R[i] = R[i + 1] * nums[i + 1]R[i]= R[i + 1]∗nums[i + 1]. Remember that R[i] represents product of all the elements to the right of element at index i.
        //Once we have the two arrays set up properly, we simply iterate over the input array one element at a time, and for each element at index i, we find the product except self as L[i] * R[i] L[i]∗R[i].
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] lp = new int[nums.Length];
            int[] rp = new int[nums.Length];

            int p = 1;
            lp[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                p = p * nums[i - 1];
                lp[i] = p;
            }

            p = 1;
            rp[nums.Length - 1] = p;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                p = p * nums[i + 1];
                rp[i] = p;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = lp[i] * rp[i];
            }

            return nums;
        }
        #endregion

        #region Range Sum BST

        // Not working.
        public static int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return 0;

            if (root.val >= L)
                return RangeSumBST(root.left, L, R);
            if (root.val <= R)
                return RangeSumBST(root.right, L, R);

            return root.val + RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R);
        }


        #endregion

        #region Set Matrix Zero
        public static void SetZeroes(int[][] matrix)
        {
            HashSet<string> marked = new HashSet<string>();

            int rows = matrix.GetLength(0);
            int cols = matrix[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var curC = string.Concat(i, ',', j);
                    if (matrix[i][j] == 0 && !marked.Contains(curC))
                    {
                        MarkCell(matrix, i, j, rows, cols, marked);
                    }
                }
            }
        }

        private static void MarkCell(int[][] m, int r, int c, int rows, int cols, HashSet<string> marked)
        {
            for (int j = 0; j < cols; j++)
            {
                var curC = string.Concat(r, ',', j);
                if (!marked.Contains(curC))
                {
                    m[r][j] = 0;
                    marked.Add(curC);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                var curC = string.Concat(i, ',', c);
                if (!marked.Contains(curC))
                {
                    m[i][c] = 0;
                    marked.Add(curC);
                }
            }
        }

        #endregion

        #region BFS of Matrix 

        const int ROW = 5;
        const int COL = 5;

        public static int CountIslands()
        {
            var m = PrepareMatrix();
            var visited = new bool[ROW, COL];

            return CountIslandsDfs(m, 0, 0, visited);
        }

        // count is not correct thoug learned the way how to handle two dimentional arrays.
        /// <summary>
        /// This will be help full in other similar problems.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="visited"></param>
        /// <returns></returns>
        private static int CountIslandsDfs(int[,] m, int i, int j, bool[,] visited)
        {
            int count = 0;
            // These arrays are used to 
            // get row and column numbers 
            // of 8 neighbors of a given cell 
            int[] rowNbr = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] colNbr = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

            Stack<Tuple<int, int>> vs = new Stack<Tuple<int, int>>();
            vs.Push(new Tuple<int, int>(i, j));

            for (int r = 0; r < ROW; r++)
            {
                for (int c = 0; c < COL; c++)
                {
                    vs.Push(new Tuple<int, int>(r, c));

                    while (vs.Count > 0)
                    {
                        var currV = vs.Pop();
                        i = currV.Item1;
                        j = currV.Item2;

                        if (m[i, j] == 1 && !visited[i, j])
                        {
                            for (int k = 0; k < 8; k++)
                            {
                                if (CanVisit(m, i + rowNbr[k], j + colNbr[k], visited))
                                {
                                    vs.Push(new Tuple<int, int>(i + rowNbr[k], j + colNbr[k]));
                                }
                            }
                        }
                    }

                    visited[i, j] = true;
                    count++;
                }
            }

            return count;
        }

        // A function to check if 
        // a given cell (row, col) 
        // can be included in DFS 
        private static bool CanVisit(int[,] m, int row,
                           int col, bool[,] visited)
        {
            // row number is in range, 
            // column number is in range 
            // and value is 1 and not 
            // yet visited 
            return (row >= 0) && (row < ROW) && (col >= 0) && (col < COL) && (m[row, col] == 1 && !visited[row, col]);
        }

        // Generic Purpose.
        private static bool IsSafe(int[,] m, int row,
                   int col)
        {
            return (row >= 0) && (row < ROW) && (col >= 0) && (col < COL);
        }


        private static int[,] PrepareMatrix()
        {
            int[,] matrix = new int[5, 5]
            {
                {1,1,0,0,0 },
                {0,1,0,0,1 },
                {1,0,0,1,1 },
                {0,0,0,0,0 },
                {1,0,1,0,1 }
            };

            return matrix;
        }


        #endregion

        #region Vertical Order Traversal of a Binary Tree

        public static IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            var nodeCoordinates = new Dictionary<TreeNode, Tuple<int, int>>();
            MarkNodes(root, nodeCoordinates, new Tuple<int, int>(0, 0));

            var dictResult = new Dictionary<int, List<int>>();

            foreach (var keyValue in nodeCoordinates)
            {
                if (!dictResult.ContainsKey(keyValue.Value.Item1))
                {
                    dictResult[keyValue.Value.Item1] = new List<int>() { keyValue.Key.val };
                }
                else
                {
                    dictResult[keyValue.Value.Item1].Add(keyValue.Key.val);
                    dictResult[keyValue.Value.Item1].Sort();
                }
            }

            dictResult.Keys.OrderByDescending(k => k);

            return dictResult.Values.ToArray();
        }

        private static void MarkNodes(TreeNode node, Dictionary<TreeNode, Tuple<int, int>> nodeCoordinates, Tuple<int, int> cds)
        {
            if (node == null)
                return;

            MarkNodes(node.left, nodeCoordinates, new Tuple<int, int>(cds.Item1 - 1, cds.Item2 - 1));
            nodeCoordinates.Add(node, cds);
            MarkNodes(node.right, nodeCoordinates, new Tuple<int, int>(cds.Item1 + 1, cds.Item2 - 1));
        }

        #endregion

        #region Lowest Common Ancestor of Deepest Leaves

        public static TreeNode LcaDeepestLeaves(TreeNode root)
        {
            if (root.left == null && root.right == null) return root;

            var result = LcaDeepestLeaves(root, 0);

            return result.Item2;
        }

        private static Tuple<int, TreeNode> LcaDeepestLeaves(TreeNode node, int depth)
        {
            if (node == null)
            {
                return new Tuple<int, TreeNode>(depth, node);
            }

            var leftPath = LcaDeepestLeaves(node.left, depth + 1);
            var rightPath = LcaDeepestLeaves(node.right, depth + 1);

            if (leftPath.Item1 > rightPath.Item1)
                return leftPath;

            if (rightPath.Item1 > leftPath.Item1)
                return rightPath;

            return new Tuple<int, TreeNode>(Math.Max(leftPath.Item1, rightPath.Item1), node);
        }

        private static void LcaDeepestLeavesDfs(TreeNode root)
        {
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            Dictionary<int, int> depths = new Dictionary<int, int>();
            int depth = 0;

            nodes.Push(root);
            TreeNode currentNode;

            while (nodes.Count > 0)
            {
                currentNode = nodes.Pop();

                if (!depths.ContainsKey(currentNode.val))
                    depths.Add(currentNode.val, depth);

                depth++;

                if (currentNode.left != null) nodes.Push(currentNode.left);
                if (currentNode.right != null) nodes.Push(currentNode.right);
            }
        }

        #endregion

        #region Lowest common ancestor of BST

        public static TreeNode LowestCommonAncestorBST(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root.val > p.val && root.val > q.val)
                return LowestCommonAncestorBST(root.left, p, q);
            else if (root.val < p.val && root.val < q.val)
                return LowestCommonAncestorBST(root.right, p, q);
            else
                return root;
        }

        #endregion

        #region First bad version

        public static int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            int mid;
            while (left < right)
            {
                mid = left + (right - left) / 2;

                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        private static bool IsBadVersion(int n)
        {
            if (n == 1702766719) return true;
            else return false;
        }

        #endregion

        #region Letter Combinations of a Phone Number

        public static IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits)) return new List<string>();

            var dicNumCharMap = GetNumberLetterMap();
            var lstResult = new List<string>();
            var map = new List<string>();

            for (int i = 0; i < digits.Length; i++)
            {
                if (dicNumCharMap.ContainsKey(digits[i]))
                    map.Add(dicNumCharMap[digits[i]]);
            }

            LetterCombinationsBuilder(map, lstResult, 0, new StringBuilder());

            return lstResult;
        }

        private static void LetterCombinationsBuilder(List<string> map, List<string> result, int sIndex, StringBuilder res)
        {
            if (sIndex == map.Count)
            {
                result.Add(res.ToString());
                return;
            }

            foreach (var ch in map[sIndex])
            {
                res.Append(ch); // Prepare the to be added to result.
                LetterCombinationsBuilder(map, result, sIndex + 1, res);
                res.Remove(res.Length - 1, 1); // Remove last character to use the next combination.
            }
        }


        /// <summary>
        /// Working solution. Though lengthy but impelmented by me. :)
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        //public static IList<string> LetterCombinations(string digits)
        //{
        //    if (string.IsNullOrEmpty(digits)) return new List<string>();

        //    var dicNumCharMap = GetNumberLetterMap();
        //    var lstResult = new List<string>();
        //    var map = new List<string>();

        //    for (int i = 0; i < digits.Length; i++)
        //    {
        //        if (dicNumCharMap.ContainsKey(digits[i]))
        //            map.Add(dicNumCharMap[digits[i]]);
        //    }

        //    if (map.Count == 1)
        //    {
        //        foreach (var ch in map[0])
        //        {
        //            lstResult.Add(ch.ToString());
        //        }

        //        return lstResult;
        //    }


        //    int j;
        //    foreach(var ch in map[0])
        //    {
        //        LetterCombinationsHelper(map, lstResult, 1, 1, ch.ToString());
        //    }

        //    return lstResult;
        //}

        private static void LetterCombinationsHelper(List<string> map, List<string> result, int sIndex, int level, string bCh)
        {
            if (level == map.Count - 1) // we are at base index
            {
                foreach (var ch in map[level])
                {
                    result.Add(string.Concat(bCh, ch));
                }

                return;
            }

            int resultIndex = result.Count;
            int j;
            foreach (var ch in map[sIndex])
            {
                LetterCombinationsHelper(map, result, sIndex + 1, level + 1, ch.ToString());
            }

            for (j = resultIndex; j < result.Count; j++)
            {
                result[j] = string.Concat(bCh, result[j]);
            }

            return;
        }

        private static Dictionary<char, string> GetNumberLetterMap()
        {
            return new Dictionary<char, string>
            {
                {'2', "abc" },
                {'3', "def" },
                {'4', "ghi" },
                {'5', "jkl" },
                {'6', "mno" },
                {'7', "pqrs" },
                {'8', "tuv" },
                {'9', "wxyz" },
            };
        }

        #endregion

        #region Premutation



        #endregion

        #region Word Break

        /// <summary>
        /// This logic is  based on Making string from dictionary word and comparing with given string.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="wordDict"></param>
        /// <returns></returns>
        //public static bool WordBreak(string s, IList<string> wordDict)
        //{
        //    if (string.IsNullOrEmpty(s)) return false;
        //        "aaaaaaa"
        //["aaaa","aaa"]


        //    return false;
        //}

        //private static void WordBreakHelper(string[] wordDict, int si, int length, Dictionary<string, string> createdWords)
        //{
        //    if (si == length) // one word only.
        //    {
        //        if (createdWords.ContainsKey(wordDict[0]))
        //            createdWords.Add(wordDict[0], wordDict[0]);
        //        return;
        //    }

        //    for (int i = si; i < length; i++)
        //    {
        //        WordBreakHelper(wordDict, i + 1, wordDict.Length - i -1, createdWords);

        //    }
        //}

        public static bool WordBreak(string s, IList<string> wordDict)
        {
            if (string.IsNullOrEmpty(s)) return true;
            wordDict = wordDict.OrderBy(q => q).ToList();

            for (int j = 0; j < wordDict.Count; j++)
            {
                string sCopy = s;
                for (int i = j; i < wordDict.Count; i++)
                {
                    sCopy = sCopy.Replace(wordDict[i], " ");
                }

                if (wordDict.Contains(sCopy.Trim())) return true;

                if (string.IsNullOrEmpty(sCopy.Trim())) return true;
            }

            return false;
        }

        #endregion

        #region Valid Palindrom

        public static bool IsPalindrome2(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return IsStringPalindrom(s, i + 1, j) || IsStringPalindrom(s, i, j - 1);
                }

                i++;
                j--;
            }

            return true;
        }

        private static bool IsStringPalindrom(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i++] != s[j--])
                    return false;
            }

            return true;
        }


        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            int i = 0;
            int j = s.Length - 1;
            bool isPelindrom = true;

            s = s.ToLower();
            while (i < j)
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }

                if (s[i] == s[j])
                {
                    i++;
                    j--;
                    continue;
                }
                else
                {
                    isPelindrom = false;
                    break;
                }
            }

            return isPelindrom;
        }

        #endregion

        #region Merge Sorted Arrays
        /// <summary>
        /// The logic is to compare elements of both the array from end. 
        /// https://www.youtube.com/watch?v=PQ-cmppVuwY
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            m--;
            n--;

            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (n < 0)
                    return;

                if (m >= 0 && nums1[m] > nums2[n]) // Reduce m if m element of num1 is greater than num2 and
                {
                    nums1[i] = nums1[m];
                    m--;
                }
                else // Reduce n if m element of num2 is greater than num1 
                {
                    nums1[i] = nums2[n];
                    n--;
                }
            }
        }

        //// correct logic but lets check the other solution.
        //public static void Merge(int[] nums1, int m, int[] nums2, int n)
        //{
        //    int p = nums1.Length - 1;

        //    for (int i = n -1; i >= 0; i--)
        //    {
        //        int n2 = nums2[i];
        //        int j = p;
        //        int zc = i + 1;
        //        int nzc = 0;
        //        int counter = 0;
        //        while(j >= 0)
        //        {
        //            if (nums1[j] != 0 && nums1[j] <= n2)
        //            {
        //                if (counter == zc) // that mean we have moved all so current element should be end of the array.
        //                {
        //                    nums1[p] = n2;
        //                    p--;
        //                   break;
        //                }
        //                else // All non zero elements should be moved towards end.
        //                {
        //                    if (nzc > 0)
        //                    {
        //                        int k = j + nzc;

        //                        while (k > j)
        //                        {
        //                            nums1[p] = nums1[k];
        //                            nums1[k] = 0;
        //                            k--;
        //                            p--;
        //                            zc--;
        //                        }
        //                    }

        //                    nums1[j + 1] = n2;
        //                    break;
        //                }
        //            }
        //            else
        //            {
        //                counter++;
        //                if (nums1[j] != 0) nzc++;
        //            }

        //            if(counter == p+1)
        //            {
        //                nums1[p] = n2;
        //                p--;
        //            }

        //            j--;
        //        }               
        //    }
        //}

        #endregion

        #region Add Binary

        /// <summary>
        /// The logic is to start sum from right to left. Take care of carry and 1 + 1 +1 scenario. Reverse the string.
        /// One more thing can be done. Just make both the number equal in size by appending leading 0 in the smaller string.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            int sum = 0;

            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 && j >= 0)
            {
                sum = CharToInt(a[i]) + CharToInt(b[j]) + carry;
                carry = 0;

                if (sum >= 2)
                {
                    sb.Append(sum - 2);
                    carry = 1;
                }
                else
                    sb.Append(sum);

                i--;
                j--;
            }

            int k = Math.Abs(a.Length - b.Length);

            if (k != 0)
            {
                if (a.Length + k == b.Length) // b is larger
                {
                    for (j = k - 1; j >= 0; j--)
                    {
                        carry = PerformSum(sb, b[j], carry);
                    }
                }

                if (b.Length + k == a.Length) // a is larger
                {
                    for (j = k - 1; j >= 0; j--)
                    {
                        carry = PerformSum(sb, a[j], carry);
                    }
                }
            }

            if (carry == 1)
                sb.Append(1);

            var result = sb.ToString().ToArray();
            Array.Reverse(result);

            return string.Join(string.Empty, result);
        }

        private static int PerformSum(StringBuilder sb, char bit, int carry)
        {
            int sum = CharToInt(bit) + carry;
            carry = 0;
            if (sum >= 2)
            {
                sb.Append(sum - 2);
                carry = 1;
            }
            else
                sb.Append(sum);

            return carry;
        }

        #endregion

        #region Merge Interval

        public static int[][] Merge(int[][] intervals)
        {

            for (int i = 0; i < intervals[0].Length; i++)
            {
                var arr1 = intervals[0][i];
                var arr2 = intervals[0][i + 1];

            }


            return null;
        }

        #endregion

        #region Next Permutation

        /// <summary>
        /// first start from right to left and find first decreasing number i.e. less than last element.
        /// Swap it with last element. then reverse it from K+ 1 to last element.
        /// </summary>
        /// <param name="nums"></param>
        public static void NextPermutation(int[] nums)
        {
            if (nums.Length <= 1) return;

            int k = nums.Length - 2;
            int temp;
            while (k >= 0 && nums[k] >= nums[k + 1])
            {
                k--;
            }

            if (k == -1)
            {
                Array.Reverse(nums);
                return;
            }

            if (k >= 0)
            {
                temp = nums[k];
                nums[k] = nums[nums.Length - 1];
                nums[nums.Length - 1] = temp;
            }

            temp = nums[nums.Length - 1];

            for (int i = k + 1; i < nums.Length - 1; i++) // Reverse the Array from k+ 1 to last element.
                nums[i + 1] = nums[i];

            nums[k + 1] = temp;
        }


        /// <summary>
        ///  The logic is to check the next permuation. Assume numbers are alphabets so it is some thing like ABC, ACB, BAC, BCA, CAB, CBA.
        ///  What is done below is to compare the last element with earlier elements in the array if there is a differece swap it.
        /// </summary>
        /// <param name="nums"></param>
        //public static void NextPermutation(int[] nums)
        //{
        //    if (nums.Length <= 1) return;

        //    int k = nums.Length - 2;
        //    int l = nums.Length - 1;

        //    while (k >=0 && nums[k] >= nums[k+1]) // If this loop run complete then all permutation is already done. Reverse it.
        //        k--;

        //    if (k == -1)
        //    {
        //        Array.Reverse(nums);
        //        return;
        //    }

        //    while(nums[k] >= nums[l])
        //        l--;

        //    int temp = nums[k];
        //    nums[k] = nums[l];
        //    nums[l] = temp;
        //}

        //public static void NextPermutation(int[] nums)
        //{
        //    if (nums.Length <= 1) return;

        //    int j = nums.Length - 1;
        //    bool swapped = false;
        //    while (j > 0)
        //    {
        //        for (int i = nums.Length - 2; i >= 0; i--)
        //        {
        //            if (i > 0 && nums[i] < nums[j])
        //            {
        //                // swap and return;
        //                int temp = nums[j];
        //                nums[j] = nums[i];
        //                nums[i] = temp;

        //                swapped = true;
        //                break;
        //            }                   
        //        }

        //        if (swapped) break;
        //        j--;
        //    }

        //    if(j == 0)
        //    {
        //        // Find a number > nums[i] and put it to the first index. then arrange the other number in ascending order.
        //        int temp = nums[nums.Length - 1];
        //        for (int k = nums.Length - 1; k > 0; k--)
        //            nums[k] = nums[k - 1];

        //        nums[0] = temp;
        //        swapped = true;
        //    }

        //    if (!swapped) Array.Reverse(nums);
        //}

        #endregion

        #region Minimum Swaps 2

        //Minimum Swaps 2
        // You are given an unordered array consisting of 'consecutive' integers  [1, 2, 3, ..., n] without any duplicates. You are allowed to swap any two elements. You need to find the minimum number of swaps 
        //required to sort the array in ascending order. The logic is to start with first element and check which ocation based on array index it should be place and swap with it. Do it again with the all the element till hte elements are sorted.


        #endregion

        #region Divide

        /// <summary>
        /// Here we are using the string manipulation
        /// Another interesting solution is to use by move divisor one bit to the left.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static int Divide(int dividend, int divisor)
        {
            int counter = 0;
            bool isDvNeg = divisor < 0;
            bool isDdNeg = dividend < 0;

            if (divisor == 1) return dividend;

            if (dividend == int.MinValue)
                dividend = int.MaxValue;
            else
                dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);

            string sDivident = dividend.ToString();
            StringBuilder sb = new StringBuilder();
            int d;

            foreach (var digit in sDivident)
            {
                sb.Append(digit);
                d = Convert.ToInt32(sb.ToString());

                if (d < divisor)
                {
                    if (counter != 0)
                        counter = counter * 10;

                    continue;
                }

                counter = counter * 10;
                while (d >= divisor)
                {
                    d = d - divisor;
                    counter++;
                }

                sb.Clear();
                sb.Append(d);
            }

            if ((isDvNeg && isDdNeg) || (!isDvNeg && !isDdNeg))
                return counter;
            else
                return -1 * counter;
        }

        /// <summary>
        /// Brute force solution
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        //public static int Divide(int dividend, int divisor)
        //{
        //    int counter = 0;
        //    bool isDvNeg = divisor < 0;
        //    bool isDdNeg = dividend < 0;

        //    if (divisor == 1) return dividend;

        //    if (dividend == int.MinValue)
        //        dividend = Math.Abs(dividend - 1);
        //    else
        //        dividend = Math.Abs(dividend);
        //    divisor = Math.Abs(divisor);

        //    while(dividend >= divisor)
        //    {
        //        dividend = dividend - divisor;
        //        counter++;
        //    }

        //    if ((isDvNeg && isDdNeg) || (!isDvNeg && !isDdNeg))
        //        return counter;
        //    else
        //        return -1 * counter;
        //}

        #endregion


        #region ThreeSome
        //         
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var resultSet = new List<IList<int>>();
            if (nums.Length == 0) return resultSet;
            if (nums.Length <= 2 && nums[0] == 0) return resultSet;
            if (nums[0] > 0) return resultSet;

            if (nums[0] == 0 && nums[nums.Length - 1] == 0)
            {
                var tempList = new List<int> { 0, 0, 0 };
                resultSet.Add(tempList);
                return resultSet;
            }

            int[] twoSums = new int[nums.Length - 2];
            int j = 0;
            for (int i = 1; i < nums.Length - 1; i++)
            {
                twoSums[j] = nums[i] + nums[i + 1];
                j++;
            }

            var uniqueSets = new Dictionary<string, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 0; k < twoSums.Length; k++)
                {
                    if (nums[i] + twoSums[k] == 0)
                    {
                        if (!uniqueSets.ContainsKey(string.Concat(nums[i], nums[k + 1], nums[k + 2])))
                        {
                            uniqueSets.Add(string.Concat(nums[i], nums[k + 1], nums[k + 2]), new List<int> { nums[i], nums[k + 1], nums[k + 2] });
                        }
                    }
                }
            }

            resultSet.AddRange(uniqueSets.Values);
            return resultSet;
        }

        #endregion

        #region Squared Array
        /// <summary>
        /// The solution logic is to create a square array. also compare the absolute values of the number then add to squared array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] SortedSquaredArray(int[] nums)
        {
            if (nums.Length == 0) return nums;
            int[] sqArr = new int[nums.Length];

            int i = 0;
            int j = nums.Length - 1;

            int sqArrIndex = sqArr.Length - 1;

            while (i <= j)
            {
                if (Math.Abs(nums[i]) > nums[j])
                {
                    sqArr[sqArrIndex] = nums[i] * nums[i];
                    i++;
                    sqArrIndex--;
                }
                else
                {
                    sqArr[sqArrIndex] = nums[j] * nums[j];
                    j--;
                    sqArrIndex--;
                }
            }

            return sqArr;
        }

        /// <summary>
        /// working but not effiicient.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //public static int[] SortedSquaredArray(int[] nums)
        //{
        //    if (nums.Length == 0) return nums;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] < 0)
        //        {
        //            nums[i] = Math.Abs(nums[i]);
        //        }
        //        else if (nums[i] > 0)
        //            break;
        //    }

        //    Array.Sort(nums);

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        nums[i] = nums[i] * nums[i];
        //    }

        //    return nums;
        //} 
        #endregion

        #region Valid Parentheses

        /// <summary>
        /// Working though logic can be improved.
        /// The current logic is to use stack to track the indexes to be remove.
        /// Created a new string as updating existing string will result in wrong removal.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string MinRemoveToMakeValid(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;

            var ci = new Stack<int>();
            var oi = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    oi.Push(i);
                    ci.Push(i);
                }

                if (s[i] == ')')
                {
                    if (oi.Count > 0 && ci.Count > 0)
                    {
                        ci.Pop();
                        oi.Pop();
                    }
                    else
                    {
                        ci.Push(i);
                    }
                }
            }

            List<int> removeIndex = new List<int>();

            // Now remove at specific indexes.
            if (oi.Count > 0)
            {
                while (oi.Count > 0)
                {
                    int index = oi.Pop();
                    removeIndex.Add(index);
                }
            }

            if (ci.Count > 0)
            {
                while (ci.Count > 0)
                {
                    int index = ci.Pop();
                    if (!removeIndex.Contains(index))
                        removeIndex.Add(index);
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (removeIndex.Contains(i))
                    continue;

                sb.Append(s[i]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// The logic is to keep a dictionary and then for each opening parentheses add an expected closing character to stack.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsValidParentheses(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return true;

            var validOpening = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            Stack<char> expectedClosing = new Stack<char>();
            foreach (var ch in str)
            {
                if (validOpening.ContainsKey(ch))
                {
                    expectedClosing.Push(validOpening[ch]);
                    continue;
                }

                if (!validOpening.ContainsKey(ch) && expectedClosing.Count == 0)
                    return false;

                if (!validOpening.ContainsKey(ch) && expectedClosing.Pop() != ch)
                    return false;
            }

            if (expectedClosing.Count > 0)
                return false;
            return true;
        }

        #endregion

        #region Steps (num ways)

        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="possibleSteps"></param>
        /// <returns></returns>
        public static int NumWays(int steps, int[] possibleSteps)
        {
            if (steps == 0) return 0;
            if (steps == 1) return 1;
            if (steps == 2) return 2;

            steps = NumWays(steps - 1, possibleSteps) + NumWays(steps - 2, possibleSteps);

            return steps;
        }

        #endregion

        #region Valid Number

        /// <summary>
        ///  Need to figure out the whether given string is numer.
        ///  Following logic focuses on symbols occurs in the string. Valid are ., -, e, +.
        ///  Trim the string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            s = s.Trim();
            if (s.Length == 1 && !char.IsDigit(s[0])) return false;

            var validChars = "+,-,.,e".Split(',').ToList();

            char pCh = '\0';

            foreach (var ch in s)
            {
                if (char.IsDigit(ch))
                {
                    pCh = ch;
                    continue;
                }

                if (pCh == '\0' && char.IsLetter(ch) && ch == 'e') return false;

                if (!validChars.Contains(ch.ToString()) || (char.IsLetter(ch) && ch != 'e'))
                    return false;

                if (pCh == 'e' && ch == '-')
                {
                    pCh = ch;
                    continue;
                }

                if (!char.IsDigit(ch) && pCh != '\0' && !char.IsDigit(pCh))
                    return false;

                pCh = ch;
            }

            if (!char.IsDigit(pCh) && pCh != '.') return false;

            return true;
        }

        #endregion

        #region Pow(x,n)

        // Calculating power via recursion as normal will take expoential time.
        public static double MyPow(double x, int n)
        {
            Console.WriteLine(string.Concat(x, '$', n));

            bool isNeg = n < 0;
            if (n == int.MinValue)
                n = int.MaxValue;
            else
                n = Math.Abs(n);

            Dictionary<string, double> memoize = new Dictionary<string, double>();

            double result = PowerHelper(x, n, memoize);

            if (x < 0 && isNeg && n == int.MaxValue && result < 0)
                result = -1.0000 * result;

            if (isNeg)
                return 1 / result;
            else
                return result;
        }

        private static double PowerHelper(double x, int n, Dictionary<string, double> memoize)
        {
            if (x == 0) return 0.0000;
            if (n == 0) return 1.0000;
            if (n == 1) return x;

            string key = string.Concat(x, '$', n);
            if (memoize.ContainsKey(key))
                return memoize[key];

            double result = 1.0000;

            if (n % 2 == 0)
            {
                result = result * PowerHelper(x, n / 2, memoize) * PowerHelper(x, n / 2, memoize);
                if (!memoize.ContainsKey(key))
                    memoize.Add(key, result);
            }
            else
            {
                result = result * PowerHelper(x, n / 2, memoize) * PowerHelper(x, (n / 2 + 1), memoize);
                if (!memoize.ContainsKey(key))
                    memoize.Add(key, result);
            }

            return result;
        }

        // Times out. Valid Code.
        //public static double MyPow(double x, int n)
        //{
        //    if (x == 0) return 0.0000;
        //    if (n == 0) return 1.0000;

        //    bool isNeg = n < 0;
        //    n = Math.Abs(n);

        //    double result = 1.0000;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result = result * x;
        //    }

        //    if (isNeg)
        //        return 1 / result;
        //    else
        //        return result;
        //}

        #endregion

        #region Multiply string
        /// <summary>
        /// The logic is to create a result array with m+n size. The multiplication of two digits (most significant digit) should stored at i+j+1 location.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private static string MultiplyString(string num1, string num2)
        {
            char[] sum = new char[num1.Length + num2.Length];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = IntToChar(0);
            }

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int carry = 0;
                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int temp = CharToInt(sum[i + j + 1]) + CharToInt(num1[i]) * CharToInt(num2[j]) + carry;
                    sum[i + j + 1] = IntToChar(temp % 10);
                    carry = temp / 10;
                }

                sum[i] = IntToChar(CharToInt(sum[i]) + carry);
            }

            var result = new string(sum).TrimStart(new[] { '0' });

            if (string.IsNullOrEmpty(result)) return "0";
            else return result;
        }

        private static int CharToInt(char inChar)
        {
            return inChar - 48;
        }

        private static char IntToChar(int inDigit)
        {
            return (char)(inDigit + 48);
        }
        #endregion
    }

    #region Random Pick Index
    public class Solution
    {
        Dictionary<int, Queue<int>> numIdx = new Dictionary<int, Queue<int>>();

        public Solution(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numIdx.ContainsKey(nums[i]))
                {
                    var q = new Queue<int>();
                    q.Enqueue(i);
                    numIdx.Add(nums[i], q);
                }
                else
                {
                    numIdx[nums[i]].Enqueue(i);
                }
            }
        }

        public int Pick(int target)
        {
            if (numIdx.ContainsKey(target))
            {
                var result = numIdx[target].Dequeue();
                numIdx[target].Enqueue(result);
                return result;
            }

            return 0;
        }
    }
    #endregion

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class TreeNode<T>
    {
        public T val;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode(T x) { val = x; }
    }
}
