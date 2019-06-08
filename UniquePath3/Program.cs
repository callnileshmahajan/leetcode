using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePath3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[3][];
            grid[0] = new int[4] { 1, 0, 0, 0 };
            grid[1] = new int[4] { 0, 0, 0, 0 };
            grid[2] = new int[4] { 0, 0, 2, -1 };

            UniquePath3(grid);

            Console.Read();
        }

        public static int UniquePath3(int[][] grid)
        {
            // If only two elements it should return 0
            if (grid.Length == 2) return 0;
            Tuple<int, int> startingSquare = null;
            Tuple<int, int> endingSquare = null;
            int nonObstacleCount = 0;

            List<List<Tuple<int, int>>> uniquePaths = new List<List<Tuple<int, int>>>();

            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 1) startingSquare = new Tuple<int, int>(row, col);
                    if (grid[row][col] == 2) endingSquare = new Tuple<int, int>(row, col);
                    if (grid[row][col] == 0) nonObstacleCount++;
                }
            }

            var path = TraverseGridDFS(grid, startingSquare, endingSquare, nonObstacleCount);
            if (path.Count == nonObstacleCount + 2) // including both starting and ending squares.
                uniquePaths.Add(path);

            return uniquePaths.Count;
        }

        private static List<Tuple<int, int>> TraverseGridDFS(int[][] grid, Tuple<int, int> startingSquare, Tuple<int, int> endingSquare, int nonObstacleCount)
        {
            List<Tuple<int, int>> path = new List<Tuple<int, int>>();

            // Traverse the grid using DFS
            Stack<Tuple<int, int>> nodesToBeTraversed = new Stack<Tuple<int, int>>();

            nodesToBeTraversed.Push(startingSquare);

            while (nodesToBeTraversed.Count > 0)
            {
                var currentNode = nodesToBeTraversed.Pop();

                // Means not all non obstacles are traversed so continue to traverse the remaining paths if any.
                if (nonObstacleCount > path.Count && endingSquare.Equals(currentNode))
                    continue;

                if (nonObstacleCount <= path.Count  && endingSquare.Equals(currentNode))
                {
                    path.Add(currentNode);
                    break;
                }

                if (!path.Contains(currentNode))
                    path.Add(currentNode);

                //Find all adjecent node having 0
                var adjecentSquares = FindAdjecentNonObstacle(grid, currentNode.Item1, currentNode.Item2, path);

                foreach (var square in adjecentSquares)
                {
                    nodesToBeTraversed.Push(square);
                }
            }

            return path;
        }

        private static List<Tuple<int, int>> FindAdjecentNonObstacle(int[][] grid, int row, int col, List<Tuple<int, int>> path)
        {
            var adjecentSquares = new List<Tuple<int, int>>();

            if (row + 1 < grid.GetLength(0) && (grid[row + 1][col] == 0 || grid[row + 1][col] == 2))
            {
                var tuple = new Tuple<int, int>(row + 1, col);

                if(!path.Contains(tuple))
                    adjecentSquares.Add(new Tuple<int, int>(row + 1, col));
            }

            if (row - 1 >= 0 && (grid[row - 1][col] == 0 || grid[row - 1][col] == 2))
            {
                var tuple = new Tuple<int, int>(row - 1, col);

                if (!path.Contains(tuple))
                    adjecentSquares.Add(new Tuple<int, int>(row - 1, col));
            }

            if (col + 1 < grid[row].Length && (grid[row][col + 1] == 0 || grid[row][col + 1] == 2))
            {
                var tuple = new Tuple<int, int>(row, col + 1);

                if (!path.Contains(tuple))
                    adjecentSquares.Add(new Tuple<int, int>(row, col + 1));
            }

            if (col - 1 >= 0 && (grid[row][col - 1] == 0 || grid[row][col - 1] == 2))
            {
                var tuple = new Tuple<int, int>(row, col - 1);

                if (!path.Contains(tuple))
                    adjecentSquares.Add(new Tuple<int, int>(row, col - 1));
            }

            return adjecentSquares;
        }
    }
}
