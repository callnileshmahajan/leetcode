using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(4);
            graph.AddEdge(1, 0, 1);
            graph.AddEdge(1, 0, 4);
            graph.AddEdge(1, 1, 0);
            graph.AddEdge(1, 1, 4);
            graph.AddEdge(1, 1, 3);
            graph.AddEdge(1, 1, 2);
            graph.AddEdge(1, 2, 1);
            graph.AddEdge(1, 2, 3);
            graph.AddEdge(1, 3, 2);
            graph.AddEdge(1, 3, 4);
            graph.AddEdge(1, 4, 0);
            graph.AddEdge(1, 4, 1);
            graph.AddEdge(1, 4, 3);

            graph.DisplayVertex(4);

            Console.Read();
        }

        public struct Graph
        {
            int[,] Matrix;

            public Graph(int numVertices)
            {
                Matrix = new int[numVertices + 1, numVertices + 1];
            }

            public void AddVertex(int vertex)
            {

            }

            public void AddEdge(int weight, int vertex1, int vertex2)
            {
                if(vertex1 < Matrix.GetLength(0) && vertex2 < Matrix.GetLength(1))
                {
                    Matrix[vertex1,vertex2] = weight;
                }
            }

            public void DisplayVertex(int vertex)
            {
                for (int i = 0; i < Matrix.GetLength(1); i++)
                {
                    if (Matrix[vertex, i] > 0)
                    {
                        Console.WriteLine($"{vertex} is connected to {i} withe weight {Matrix[vertex, i]}");
                    }
                }
            }

            public void DFSTraversal()
            {

            }
        }
    }
}
