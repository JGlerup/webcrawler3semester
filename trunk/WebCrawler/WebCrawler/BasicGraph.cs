using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler
{
    class BasicGraph : IBasicGraph
    {
        private IList<Vertex> vertices;
        private IList<Vertex> dfSearch;
        private IList<Edge> edges;

        public Edge FindEdge(Vertex startVertex, Vertex endVertex)
        {
            bool found = false;
            int index = 0;
            Edge edge = null;
            while (!found && index < edges.Count)
            {
                Edge e = edges[index];
                if (e.StartVertex == startVertex && e.EndVertex == endVertex)
                {
                    found = true;
                    edge = e;
                }
                index++;
            }
            return edge;
        }
        
        public void AddVertex(Vertex vertex)
        {
            vertices.Add(vertex);
        }

        public void AddEdge(Vertex startVertex, Vertex endVertex)
        {
            edges.Add(new Edge(startVertex, endVertex));
        }

        public void RemoveVertex(Vertex v)
        {
            vertices.Remove(v);
        }

        public void RemoveEdge(Vertex from, Vertex to)
        {
            edges.Remove(FindEdge(from, to));
        }

        public bool ContainsVertex(Vertex vertex)
        {
            throw new NotImplementedException();
        }

        public bool IsAdjacent(Vertex startVertex, Vertex endVertex)
        {
            return FindEdge(startVertex, endVertex) == null;
        }

        public System.Collections.IList GetAdjacencies(Vertex vertex)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IEnumerator Vertices()
        {
            return vertices.GetEnumerator();
        }

        public System.Collections.IEnumerator Edges()
        {
            return edges.GetEnumerator();
        }

        public bool IsEmpty()
        {
            return vertices.Count == 0;
        }

        public int GetNoOfVertices()
        {
            return vertices.Count;
        }

        public int GetNoOfEdges()
        {
            return edges.Count;
        }

        public void Clear()
        {
            vertices.Clear();
            edges.Clear();
        }

        public System.Collections.IList DepthFirstSearch(Vertex v)
        {
            throw new NotImplementedException();
        }
    }
}
