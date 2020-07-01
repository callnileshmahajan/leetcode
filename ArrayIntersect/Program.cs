using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayIntersect
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = new int[] { 4, 9, 5 };
            //int[] nums2 = new int[] { 9, 4, 9, 8, 4 };
            int[] nums1 = new int[] { 21, 47, 80, 4, 3, 24, 87, 12, 22, 11, 48, 6, 89, 80, 74, 71, 74, 55, 58, 56, 4, 98, 40, 66, 49, 53, 62, 27, 3, 66, 78, 24, 48, 69, 88, 12, 80, 63, 98, 65, 46, 35, 72, 5, 64, 72, 7, 29, 37, 3, 2, 75, 44, 93, 79, 78, 13, 39, 85, 26, 15, 41, 87, 47, 29, 93, 41, 74, 6, 48, 17, 89, 27, 61, 2, 68, 99, 57, 45, 73, 25, 33, 38, 32, 58 };
            int[] nums2 = new int[] { 1, 39, 6, 81, 85, 10, 38, 22, 0, 89, 57, 93, 58, 69, 65, 80, 84, 24, 27, 54, 37, 36, 26, 88, 2, 7, 24, 36, 51, 5, 74, 57, 45, 56, 55, 67, 25, 33, 78, 49, 16, 79, 74, 80, 36, 27, 89, 49, 64, 73, 96, 60, 92, 31, 98, 72, 22, 31, 0, 93, 70, 87, 80, 66, 75, 69, 81, 52, 94, 90, 51, 90, 74, 36, 58, 38, 50, 9, 64, 55, 4, 21, 49, 60, 65, 47, 67, 8, 38, 83 };

            //int[] nums1 = new int[] { 2, 1 };
            //int[] nums2 = new int[] { 1, 2 };

            //int[] nums1 = new int[] { 1, 2 };
            //int[] nums2 = new int[] { 1, 1 };

            //int[] nums1 = new int[] { 1, 2, 2, 1 };
            //int[] nums2 = new int[] { 2, 2 };

            //int[] nums1 = new int[] { 3, 1, 2 };
            //int[] nums2 = new int[] { 1, 1 };

            //int[] nums1 = new int[] { 1 };
            //int[] nums2 = new int[] { 1 };

            //int[] nums1 = new int[] { 1 };
            //int[] nums2 = new int[] { 1, 1 };

            var result = Intersect(nums1, nums2);

            Console.Read();
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();

            if (nums1.Length == 0 || nums2.Length == 0) return result.ToArray();

            int x = 0;
            int y = 0;

            int dim1 = nums1.Length;
            int dim2 = nums2.Length;

            bool iterator = dim1 > dim2;
            int[] pNums1;
            int[] pNums2;

            if (iterator)
            {
                pNums1 = nums1.OrderBy(n => n).ToArray();
                pNums2 = nums2.OrderBy(n => n).ToArray();
            }
            else
            {
                pNums1 = nums2.OrderBy(n => n).ToArray();
                pNums2 = nums1.OrderBy(n => n).ToArray();
            }

            int matchFoundIndex = -1;
            // Avoid same mapping
            List<int> mappedX = new List<int>();

            while (true)
            {
                if (x == pNums1.Length && y == pNums2.Length) break;

                if (x == pNums1.Length) x = 0;
                if (y == pNums2.Length) break;

                if (pNums1[x] == pNums2[y] && !mappedX.Contains(x))
                {
                    result.Add(pNums1[x]);
                    matchFoundIndex = x;
                    mappedX.Add(x);
                    x++;
                    y++;
                }
                else
                {
                    x++;

                    if (x == pNums1.Length)
                    {
                        y++;

                        if (y == pNums2.Length) break;

                        x = matchFoundIndex + 1;
                    }
                }
            }

            return result.ToArray();
        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            int[,] intersectionMatrix = CreateIntersectionMatrix(nums1, nums2);
            int[] result = new int[0];
            int i = 0, j = 0;

            int dim1 = intersectionMatrix.GetLength(0);
            int dim2 = intersectionMatrix.GetLength(1);

            if (dim1 == 2 && dim2 == 2)
            {
                List<int> matchingNumber = new List<int>();
                for (int k = 0; k < dim1; k++)
                {
                    for (int l = 0; l < dim2; l++)
                    {
                        if (nums1[k] == nums2[l])
                        {
                            if (!matchingNumber.Contains(nums1[k]))
                                matchingNumber.Add(nums1[k]);
                        }
                    }
                }

                if (matchingNumber.Count > 0)
                    return matchingNumber.ToArray();
            }

            bool compareDiagonal = (dim1 > 2 && dim2 > 2) || (dim1 >= 2 && dim2 > 2) || (dim1 > 2 && dim2 >= 2);
            bool condition = false;

            for (i = 0; i < dim1; i++)
            {
                for (j = 0; j < dim2; j++)
                {
                    if (compareDiagonal && i + 1 >= dim1)
                        continue;

                    if (!compareDiagonal)
                        condition = intersectionMatrix[i, j] == 1;
                    else if (compareDiagonal && j + 1 >= dim2)
                        condition = intersectionMatrix[i, j] == 1 && intersectionMatrix[i + 1, j - 1] == 1;
                    else if (compareDiagonal && j == 0)
                        condition = (intersectionMatrix[i, j] == 1 && intersectionMatrix[i + 1, j + 1] == 1);
                    else if (compareDiagonal)
                        condition = (intersectionMatrix[i, j] == 1 && intersectionMatrix[i + 1, j + 1] == 1) || (intersectionMatrix[i, j] == 1 && intersectionMatrix[i + 1, j - 1] == 1);

                    if (condition)
                    {
                        int arraylength = compareDiagonal ? 2 : 1;
                        result = new int[arraylength];
                        result[0] = nums1[i];

                        if (arraylength == 2)
                            result[1] = nums1[i + 1];
                        break;
                    }
                }
            }

            return result;
        }

        public static int[,] CreateIntersectionMatrix(int[] num1, int[] num2)
        {
            int[,] intersectionMatrix = new int[num1.Length, num2.Length];

            for (int i = 0; i < intersectionMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < intersectionMatrix.GetLength(1); j++)
                {
                    intersectionMatrix[i, j] = num1[i] == num2[j] ? 1 : 0;
                }
            }

            return intersectionMatrix;
        }

        public static void TraverseMatrix(int[,] matrix)
        {
            int dim1 = matrix.GetLength(0);
            int dim2 = matrix.GetLength(1);

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    MatrixElement element = KindOfElement(i, j, dim1, dim2);
                    switch (element)
                    {
                        case MatrixElement.Conrner:

                            break;
                        case MatrixElement.Side:
                            break;
                        case MatrixElement.Middle:
                            break;
                    }
                }
            }
        }

        public static MatrixElement KindOfElement(int i, int j, int dim1, int dim2)
        {
            if ((i == 0 && j == 0) || (i == dim1 - 1 && j == dim2 - 1) || (i == 0 && j == dim2 - 1) || (i == dim1 - 1 && j == 0)) return MatrixElement.Conrner;  // 3 comparision

            if ((i == 0 && (j > 0 && j < dim2 - 1)) || (j == 0 && (i > 0 && i < dim1 - 1))) return MatrixElement.Side;

            return MatrixElement.Conrner;
        }


        public enum MatrixElement
        {
            Conrner,
            Side,
            Middle
        }
    }
}
