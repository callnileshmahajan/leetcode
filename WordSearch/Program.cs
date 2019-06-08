using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[3][];
            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'C', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };
            //board[3] = new char[] { 'a', 'a', 'a', 'b', 'a', 'a' };
            //board[4] = new char[] { 'a', 'b', 'a', 'a', 'b', 'b' };
            //board[0] = new char[] { 'a' };

            var result = Exist(board, "ABCCED");
            Console.Read();
        }

        public static bool Exist(char[][] board, string word)
        {
            HashSet<Tuple<int, int>> visitedCells = new HashSet<Tuple<int, int>>();
            bool success = false;

            int row = 0;
            int col = 0;

            while (row != -1 || col != -1)
            {
                int wordCharIndex = 0;
                visitedCells.Clear();

                var matchingCell = FindFirstMatchingLetter(board, word[wordCharIndex], row, col);
                if (matchingCell.Item1 == -1 || matchingCell.Item2 == -1) return false;

                if (word == board[matchingCell.Item1][matchingCell.Item2].ToString()) return true;
                
                var nextCell = GetNextCell(matchingCell.Item1, matchingCell.Item2, board.GetLength(0), board[0].Length);
                row = nextCell.Item1;
                col = nextCell.Item2;

                visitedCells.Add(matchingCell);
                wordCharIndex++;
                
                success = SearchWordHelper(board, word.Substring(wordCharIndex), matchingCell.Item1, matchingCell.Item2, visitedCells);

                if (success) return true;
            }

            return success;
        }

        private static bool SearchWordHelper(char[][] board, string word, int row, int col, HashSet<Tuple<int, int>> visitedCells)
        {
            bool success = false;

            if (word.Length == 0) return true;

            Tuple<int, int> matchingCell;
            Stack<Tuple<int, int>> matchingAdjcentCells = new Stack<Tuple<int, int>>();
            int visitedCellCount = visitedCells.Count;

            if (GetNextMatchingAdjecentCells(board, row, col, word[0], matchingAdjcentCells, visitedCells))
            {
                while (!success && matchingAdjcentCells.Count > 0)
                {
                    matchingCell = matchingAdjcentCells.Pop();
                    visitedCells.Add(matchingCell);
                    success = SearchWordHelper(board, word.Substring(1), matchingCell.Item1, matchingCell.Item2, visitedCells);

                    if (!success)
                        visitedCells = visitedCells.Take(visitedCellCount).ToHashSet();
                }
            }

            return success;
        }
        
        private static Tuple<int, int> FindFirstMatchingLetter(char[][] board, char firstChar, int r, int c)
        {
            for (int row = r; row < board.GetLength(0); row++)
            {
                for (int col = c; col < board[r].Length; col++)
                {
                    c = 0;
                    if (board[row][col] == firstChar)
                        return new Tuple<int, int>(row, col);
                }
            }

            return new Tuple<int, int>(-1, -1);
        }

        private static Tuple<int, int> GetNextCell(int row, int col, int rows, int cols)
        {
            Tuple<int, int> nextCell;

            if (col + 1 == cols)
            {
                nextCell = new Tuple<int, int>(row + 1, 0);
            }
            else
            {
                nextCell = new Tuple<int, int>(row, col + 1);
            }

            return nextCell;
        }
        
        private static bool GetNextMatchingAdjecentCells(char[][] board, int row, int col, char nextChar, Stack<Tuple<int, int>> matchingCells, HashSet<Tuple<int, int>> visitedCells)
        {
            bool isMatchFound = false;
            // Check horizontal Neighboures  // TODO: Check index.
            if (((col + 1) < board[row].Length) && board[row][col + 1] == nextChar)
            {
                var cell = new Tuple<int, int>(row, col + 1);
                if (!visitedCells.Contains(cell))
                {
                    matchingCells.Push(cell);
                  //  visitedCells.Add(cell);
                    isMatchFound = true;
                }
            }

            if (((col - 1) >= 0 && board[row][col - 1] == nextChar))
            {
                var cell = new Tuple<int, int>(row, col - 1);
                if (!visitedCells.Contains(cell))
                {
                    matchingCells.Push(cell);
                  //  visitedCells.Add(cell);
                    isMatchFound = true;
                }
            }

            // now vertical neighboures.
            if (((row + 1) < board.GetLength(0)) && board[row + 1][col] == nextChar)
            {
                var cell = new Tuple<int, int>(row + 1, col);
                if (!visitedCells.Contains(cell))
                {
                    matchingCells.Push(cell);
                  //  visitedCells.Add(cell);
                    isMatchFound = true;
                }
            }

            if (((row - 1) >= 0) && board[row - 1][col] == nextChar)
            {
                var cell = new Tuple<int, int>(row - 1, col);
                if (!visitedCells.Contains(cell))
                {
                    matchingCells.Push(cell);
                 //   visitedCells.Add(cell);
                    isMatchFound = true;
                }
            }

            return isMatchFound;
        }

        // NOTE: Following method is working.
        //public static bool Exist(char[][] board, string word)
        //{
        //    HashSet<Tuple<int, int>> visitedCells = new HashSet<Tuple<int, int>>();
        //    Stack<Tuple<int, int>> matchingAdjcentCells = new Stack<Tuple<int, int>>();

        //    bool success = false;

        //    int row = 0;
        //    int col = 0;

        //    while (row != -1 || col != -1)
        //    {
        //        int wordCharIndex = 0;
        //        visitedCells.Clear();

        //        var matchingCell = FindFirstMatchingLetter(board, word[wordCharIndex], row, col);
        //        if (matchingCell.Item1 == -1 || matchingCell.Item2 == -1) return false;

        //        if (word == board[matchingCell.Item1][matchingCell.Item2].ToString()) return true;

        //        visitedCells.Add(matchingCell);
        //        var nextCell = GetNextCell(matchingCell.Item1, matchingCell.Item2, board.GetLength(0), board[0].Length);
        //        row = nextCell.Item1 ;
        //        col = nextCell.Item2;
        //        wordCharIndex++;

        //        if (wordCharIndex < word.Length && GetNextMatchingAdjecentCells(board, matchingCell.Item1, matchingCell.Item2, word[wordCharIndex], matchingAdjcentCells, visitedCells))
        //        {
        //            wordCharIndex++;

        //            while (matchingAdjcentCells.Count > 0)
        //            {
        //                matchingCell = matchingAdjcentCells.Pop();
        //                visitedCells.Add(matchingCell);
        //                success = SearchWordHelper(board, word.Substring(wordCharIndex), matchingCell.Item1, matchingCell.Item2, visitedCells);
        //                if (success) return true;
        //            }
        //        } 
        //    }

        //    return success;
        //}

    }
}
