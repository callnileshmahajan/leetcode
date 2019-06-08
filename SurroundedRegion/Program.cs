using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurroundedRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[5][];
            board[0] = new char[5] { 'O', 'X', 'X', 'O', 'X' };
            board[1] = new char[5] { 'X', 'O', 'O', 'X', 'O' };
            board[2] = new char[5] { 'X', 'O', 'X', 'O', 'X' };
            board[3] = new char[5] { 'O', 'X', 'O', 'O', 'O' };
            board[3] = new char[5] { 'X', 'X', 'O', 'X', 'O' };
            Solve(board);
            Console.Read();
        }

        public static void Solve(char[][] board)
        {
            BFSTraversal(board);
        }

        private static void BFSTraversal(char[][] board)
        {
            if (board.Length == 0) return;
            Tuple<int, int> firstNode = new Tuple<int, int>(0, 0);
            int rows = board.GetLength(0);
            int cols = board[0].Length;
            Queue<Tuple<int, int>> nodesToBeTraversed = new Queue<Tuple<int, int>>();
            List<Tuple<int, int>> alreadyVisited = new List<Tuple<int, int>>();
            alreadyVisited.Add(firstNode);
            nodesToBeTraversed.Enqueue(firstNode);

            while (nodesToBeTraversed.Count > 0)
            {
                var node = nodesToBeTraversed.Dequeue();

                if (board[node.Item1][node.Item2] != 'X') // O
                {
                    if (!IsBorderNode(node.Item1, node.Item2, rows, cols) && !IsAdjecentNodeO(node.Item1, node.Item2, board))
                    {
                        board[node.Item1][node.Item2] = 'O';
                    }
                }

                var tuples = FindAdjecentNodes(node.Item1, node.Item2, rows, cols);

                foreach (var item in tuples)
                {
                    if (!alreadyVisited.Contains(item))
                    {
                        alreadyVisited.Add(item);
                        nodesToBeTraversed.Enqueue(item);
                    }
                }
            }
        }

        private static List<Tuple<int, int>> FindAdjecentNodes(int row, int col, int rows, int cols)
        {
            var tuples = new List<Tuple<int, int>>();
            if (row - 1 >= 0)
                tuples.Add(new Tuple<int, int>(row - 1, col));
            if (row + 1 < rows)
                tuples.Add(new Tuple<int, int>(row + 1, col));

            if (col - 1 >= 0)
                tuples.Add(new Tuple<int, int>(row, col - 1));
            if (col + 1 < cols)
                tuples.Add(new Tuple<int, int>(row, col + 1));

            return tuples;
        }

        private static bool IsBorderNode(int row, int col, int rows, int cols)
        {
            return row == 0 || col == 0 || row == rows - 1 || col == cols - 1;
        }

        private static bool IsAdjecentNodeO(int row, int col, char[][] board)
        {
            if (row - 1 == 0 && board[0][col] == 'O')
                return true;
            if (row + 1 == board.GetLength(0) - 1 && board[row + 1][col] == 'O')
                return true;

            if (col - 1 == 0 && board[row][0] == 'O')
                return true;
            if (col + 1 == board[0].Length - 1 && board[row][col + 1] == 'O')
                return true;

            return false;
        }
    }
}
