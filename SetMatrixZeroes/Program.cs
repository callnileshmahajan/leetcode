using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetMatrixZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            //matrix[0] = new int[3] { 1, 1, 1 };
            //matrix[1] = new int[3] { 1, 0, 1 };
            //matrix[2] = new int[3] { 1, 1, 1 };
            //---------------------------------------------
            matrix[0] = new int[4] { 0, 1, 2, 0 };
            matrix[1] = new int[4] { 3, 4, 5, 2 };
            matrix[2] = new int[4] { 1, 3, 1, 5 };

            //matrix[0] = new int[12] { 9, 8, 5, 1, 8, 0, 7, 3, 4, 1, 2, 0 };
            //matrix[1] = new int[12] { 1, 4, 3, 3, 8, 1, 6, 9, 3, 5, 7, 3 };
            //matrix[2] = new int[12] { 2, 5, 0, 9, 5, 9, 6, 4, 8, 4, 7, 6 };
            //matrix[3] = new int[12] { 4, 5, 2, 0, 8, 4, 3, 1, 0, 6, 4, 8 };
            //matrix[4] = new int[12] { 9, 0, 9, 5, 7, 7, 0, 9, 2, 2, 0, 9 };
            //matrix[5] = new int[12] { 2, 7, 6, 2, 1, 3, 0, 7, 0, 2, 7, 0 };
            //matrix[6] = new int[12] { 6, 0, 2, 8, 9, 6, 6, 0, 9, 6, 7, 6 };
            //matrix[7] = new int[12] { 3, 8, 8, 7, 0, 8, 9, 4, 7, 5, 6, 0 };
            //matrix[8] = new int[12] { 0, 9, 7, 3, 1, 7, 3, 0, 9, 7, 8, 8 };
            //matrix[9] = new int[12] { 6, 7, 1, 5, 3, 8, 3, 8, 6, 1, 7, 9 };
            //matrix[10] = new int[12] { 2, 6, 3, 9, 1, 2, 2, 4, 1, 9, 7, 4 };
            //matrix[11] = new int[12] { 8, 0, 4, 8, 8, 5, 8, 4, 2, 9, 1, 7 };

            SetZeroes(matrix);

            Console.Read();
        }

        public static void SetZeroes(int[][] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix[0].Length;

            // Keep track of which cells have been marked.
            HashSet<string> markedCells = new HashSet<string>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var key = string.Concat(i, ',', j);
                    if (markedCells.Contains(key))
                        continue;

                    if (matrix[i][j] == 0)
                    {
                        MarkCells(ref matrix, markedCells, i, j, rows, cols);
                    }
                }
            }
        }

        private static void MarkCells(ref int[][] matrix, HashSet<string> markedCells, int i, int j, int rows, int cols)
        {
            for (int m = 0; m < cols; m++) // marking the remaing cols.
            {
                if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i, ',', m)))
                {
                    matrix[i][m] = 0;
                    if (m != j) // same col should not be marked.
                        markedCells.Add(string.Concat(i, ',', m));
                }
            }

            for (int m = 0; m < rows; m++) // mark row downwords.
            {
                if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m, ',', j)))
                {
                    matrix[m][j] = 0;
                    if (m != i)
                        markedCells.Add(string.Concat(m, ',', j));
                }
            }
        }

        //private static void MarkCells(ref int[][] matrix, List<string> markedCells, int i, int j)
        //{
        //    int rows = matrix.GetLength(0);
        //    int cols = matrix[0].Length;

        //    if (i - 1 < 0) //first Row
        //    {
        //        if (j - 1 < 0) // Top Left corner
        //        {
        //            for (int m = j + 1; m < cols; m++) // marking the remaing rows.
        //            {
        //                if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i,m)))
        //                {
        //                    matrix[i][m] = 0;
        //                    markedCells.Add(string.Concat(i, m)); 
        //                }
        //            }

        //            for (int m = i + 1; m < rows; m++)
        //            {
        //                if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m, j)))
        //                {
        //                    matrix[m][j] = 0;
        //                    markedCells.Add(string.Concat(m, j)); 
        //                }
        //            }
        //        }
        //        else
        //        {
        //            for (int m =0; m < cols; m++) // marking the remaing rows.
        //            {
        //                if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i, m)))
        //                {
        //                    matrix[i][m] = 0;

        //                    if (m != j) // do not mark already 0 element.
        //                        markedCells.Add(string.Concat(i, m)); 
        //                }
        //            }

        //            for (int m = 0; m < rows; m++)
        //            {
        //                if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m, j)))
        //                {
        //                    matrix[m][j] = 0;
        //                    if (m != i ) // do not mark already 0 element.
        //                        markedCells.Add(string.Concat(m, j)); 
        //                }
        //            }
        //        }
        //    } // Closign first row if

        //    if(j + 1 > cols) // Last column 
        //    {
        //        if(i -1 < 0) // Top right
        //        {
        //            for (int m = j - 1; m >= 0; m--) // marking the remaing rows.
        //            {
        //                if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i, m)))
        //                {
        //                    matrix[i][m] = 0;
        //                    markedCells.Add(string.Concat(i, m));
        //                }
        //            }

        //            for (int m = i + 1; m < rows; m++)
        //            {
        //                if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m, j)))
        //                {
        //                    matrix[m][j] = 0;
        //                    markedCells.Add(string.Concat(m, j));
        //                }
        //            }
        //        }
        //        else
        //        {
        //            for (int m = 0; m < rows; m++) // marking the remaing rows.
        //            {
        //                if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m,j)))
        //                {
        //                    matrix[m][j] = 0;

        //                    if (m != j) // do not mark already 0 element.
        //                        markedCells.Add(string.Concat(m, j));
        //                }
        //            }

        //            for (int m = j-1; m >= 0; m--)
        //            {
        //                if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i, m)))
        //                {
        //                    matrix[i][m] = 0;
        //                   markedCells.Add(string.Concat(m, j));
        //                }
        //            }
        //        }
        //    } // Closing last column

        //    if(j - 1 < 0) // last Colums last row.
        //    {
        //        if (i + 1 >= rows) // bottom left corner
        //        {
        //            for (int m = j + 1; m < cols; m++) // marking the remaing cols.
        //            {
        //                if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i, m)))
        //                {
        //                    matrix[i][m] = 0;
        //                    markedCells.Add(string.Concat(i, m));
        //                }
        //            }

        //            for (int m = i - 1; m >= 0; m--) // mark upwards.
        //            {
        //                if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m, j)))
        //                {
        //                    matrix[m][j] = 0;
        //                    markedCells.Add(string.Concat(m, j));
        //                }
        //            }
        //        }
        //        else
        //        {
        //            for (int m = 0; m < cols; m++) // marking the remaing cols.
        //            {
        //                if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i, m)))
        //                {
        //                    matrix[i][m] = 0;
        //                    markedCells.Add(string.Concat(i, m));
        //                }
        //            }

        //            for (int m = 0; m < rows; m++)
        //            {
        //                if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m, j)))
        //                {
        //                    matrix[m][j] = 0;
        //                    if (m != i) // do not mark already 0 element.
        //                        markedCells.Add(string.Concat(m, j));
        //                }
        //            }
        //        }               
        //    } // Closing j - 1 if

        //    if(j + 1 >= cols) // last colmn last row
        //    {
        //        if(i + 1 >= rows) // bottom right corner.
        //        {
        //            for (int m = j -1; m >=0; m--) // marking the remaing cols.
        //            {
        //                if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i, m)))
        //                {
        //                    matrix[i][m] = 0;
        //                    markedCells.Add(string.Concat(i, m));
        //                }
        //            }

        //            for (int m = i - 1; m >= 0; m--) // mark upwards.
        //            {
        //                if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m, j)))
        //                {
        //                    matrix[m][j] = 0;
        //                    markedCells.Add(string.Concat(m, j));
        //                }
        //            }
        //        }
        //        else
        //        {
        //            for (int m = j - 1; m >= 0; m--) // marking the remaing cols.
        //            {
        //                if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i, m)))
        //                {
        //                    matrix[i][m] = 0;
        //                    markedCells.Add(string.Concat(i, m));
        //                }
        //            }

        //            for (int m = 0; m < rows; m++) // mark row downwords.
        //            {
        //                if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m, j)))
        //                {
        //                    matrix[m][j] = 0;
        //                    if(m != i)
        //                        markedCells.Add(string.Concat(m, j));
        //                }
        //            }
        //        }
        //    }

        //    if(i + 1 < rows && i > 0 && j > 0 && j + 1 < rows) // Somewhere in between
        //    {
        //        MarkCenterCells(ref matrix, markedCells, i, j, rows, cols);
        //    }
        //}

        //public void SetZeroes(int[][] matrix)
        //{
        //    int rows = matrix.GetLength(0);
        //    int cols = matrix[0].Length;

        //    // Keep track of which cells have been marked.
        //    HashSet<string> markedCells = new HashSet<string>();

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            var key = string.Concat(i, ',', j);
        //            if (markedCells.Contains(key))
        //                continue;

        //            if (matrix[i][j] == 0)
        //            {
        //                MarkCells(ref matrix, markedCells, i, j, rows, cols);
        //            }
        //        }
        //    }
        //}


        //private static void MarkCells(ref int[][] matrix, HashSet<string> markedCells, int i, int j, int rows, int cols)
        //{
        //    for (int m = 0; m < cols; m++) // marking the remaing cols.
        //    {
        //        if (matrix[i][m] != 0 && !markedCells.Contains(string.Concat(i, ',', m)))
        //        {
        //            matrix[i][m] = 0;
        //            if (m != j) // same col should not be marked.
        //                markedCells.Add(string.Concat(i, ',', m));
        //        }
        //    }

        //    for (int m = 0; m < rows; m++) // mark row downwords.
        //    {
        //        if (matrix[m][j] != 0 && !markedCells.Contains(string.Concat(m, ',', j)))
        //        {
        //            matrix[m][j] = 0;
        //            if (m != i)
        //                markedCells.Add(string.Concat(m, ',', j));
        //        }
        //    }

        //}
    }
}

