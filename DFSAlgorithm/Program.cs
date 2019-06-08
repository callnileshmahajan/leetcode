using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(9);

            //graph.AddEdge(1, 0, 1);
            //graph.AddEdge(1, 0, 2);
            //graph.AddEdge(1, 0, 3);
            //graph.AddEdge(1, 1, 0);
            //graph.AddEdge(1, 1, 2);
            //graph.AddEdge(1, 2, 0);
            //graph.AddEdge(1, 2, 1);
            //graph.AddEdge(1, 2, 4);
            //graph.AddEdge(1, 3, 0);
            //graph.AddEdge(1, 4, 2);


            graph.AddEdge(1, 0, 1);
            graph.AddEdge(1, 0, 8);
            graph.AddEdge(1, 8, 2);
            graph.AddEdge(1, 8, 6);
            graph.AddEdge(1, 2, 3);
            graph.AddEdge(1, 2, 4);
            graph.AddEdge(1, 2, 5);
            graph.AddEdge(1, 4, 2);
            graph.AddEdge(1, 4, 7);
            graph.AddEdge(1, 5, 2);
            graph.AddEdge(1, 5, 6);
            graph.AddEdge(1, 6, 5);
            graph.AddEdge(1, 6, 7);


            graph.DFSTraversal();
            Console.WriteLine("--------------------------------");
            graph.BFSTraversal();
            Console.Read();
        }
    }

    public class Graph
    {
        private int _numVertices;
        List<Node> _nodes;

        public Graph(int numVertices)
        {
            _nodes = new List<Node>();
            _numVertices = numVertices;

            InitializeGraph();

        }

        private void InitializeGraph()
        {
            if (_numVertices > 0)
            {
                for (int i = 0; i < _numVertices; i++)
                {
                    var node = new Node(i);                   
                    _nodes.Add(node);
                }
            }
        }

        public void AddVertex(int vertex)
        {
           // TODO: To be implemented.
        }

        public void AddEdge(int weight, int vertex1, int vertex2)
        {
            foreach (var node in _nodes)
            {
                if(node.Information.Equals(vertex1) && !node.AdjcentNodes.Any(n => n.Information.Equals(vertex2)))
                {
                    // Find the vertex2 and create an edge betewen them.
                    var localNode = _nodes.Where(n => n.Information.Equals(vertex2)).First();
                    localNode.Edges.Add(new Edge(weight));

                    // Create the relationship.
                    node.AdjcentNodes.Add(localNode);
                    localNode.AdjcentNodes.Add(node);

                    break;
                }
            }
        }

        public void DisplayVertex(int vertex)
        {
           // TODO: To be implemented.
        }

        public void DFSTraversal()
        {
            List<Node> alreadyVisited = new List<Node>();
            Stack<Node> nodesToBeTraversed = new Stack<Node>();

            nodesToBeTraversed.Push(_nodes.First());

            while (nodesToBeTraversed.Count > 0)
            {
                var node = nodesToBeTraversed.Pop();

                if (!alreadyVisited.Contains(node))
                {
                    Console.WriteLine($"Traversed: {node.Information}");
                    alreadyVisited.Add(node);
                    
                    var adjcentNodes = node.AdjcentNodes.OrderByDescending(n => n.Information).ToList();

                    for (int i = 0; i <= adjcentNodes.Count-1; i++)
                    {
                        if (!nodesToBeTraversed.Contains(adjcentNodes[i]) && !alreadyVisited.Contains(adjcentNodes[i]))
                        {
                            nodesToBeTraversed.Push(adjcentNodes[i]);
                        }
                    }
                }
            }
        }

        public void BFSTraversal()
        {
            List<Node> alreadyVisited = new List<Node>();
            Queue<Node> nodesToBeTraversed = new Queue<Node>();

            nodesToBeTraversed.Enqueue(_nodes.First());

            while (nodesToBeTraversed.Count > 0)
            {
                var node = nodesToBeTraversed.Dequeue();

                if (!alreadyVisited.Contains(node))
                {
                    Console.WriteLine($"Traversed: {node.Information}");
                    alreadyVisited.Add(node);

                    var adjcentNodes = node.AdjcentNodes.OrderBy(n => n.Information);

                    for (int i =  0; i <= adjcentNodes.Count() - 1; i++)
                    {
                        if (!nodesToBeTraversed.Contains(node.AdjcentNodes[i]) && !alreadyVisited.Contains(node.AdjcentNodes[i]))
                        {
                            nodesToBeTraversed.Enqueue(node.AdjcentNodes[i]);
                        }
                    }
                }
            }
        }
    }

    public class Node
    {
   
        public Node(int information)
        {
            Information = information;
            AdjcentNodes = new List<Node>();
            Edges = new List<Edge>();
        }

        public int Information { get; set; }

        public List<Edge> Edges{ get; set; }

        /// <summary>
        /// Gets or sets Adjcent nodes.
        /// </summary>
        public List<Node> AdjcentNodes { get; set; }        
    }

    public class Edge
    {
        public int Weight { get; set; }

        public Edge(int weight)
        {
            Weight = weight;
        }
    }
}
