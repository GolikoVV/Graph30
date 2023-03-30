using System;
using System.Collections.Generic;
using System.Text;

namespace Graph30
{
    class Graph<T>
    {
        private Dictionary<T, List<T>> adj; // словарь смежности

        public Graph()
        {
            adj = new Dictionary<T, List<T>>();
        }

        public void AddVertex(T v)
        {
            adj.Add(v, new List<T>());
        }

        public void AddEdge(T v, T w)
        {
            adj[v].Add(w);
        }

        public void DFS(T v, HashSet<T> visited)
        {
            visited.Add(v);
            Console.Write(v + " ");

            foreach (T i in adj[v])
            {
                if (!visited.Contains(i))
                    DFS(i, visited);
            }
        }

        public void Traverse()
        {
            HashSet<T> visited = new HashSet<T>();
            foreach (T v in adj.Keys)
            {
                if (!visited.Contains(v))
                    DFS(v, visited);
            }
        }
    }
}
