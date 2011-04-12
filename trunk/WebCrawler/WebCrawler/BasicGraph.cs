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
            throw new NotImplementedException();
        }

        public bool ContainsVertex(Vertex vertex)
        {
            throw new NotImplementedException();
        }

        public bool IsAdjacent(Vertex startVertex, Vertex endVertex)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IList GetAdjacencies(Vertex vertex)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IEnumerator Vertices()
        {
            throw new NotImplementedException();
        }

        public System.Collections.IEnumerator Edges()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public System.Collections.IList DepthFirstSearch(Vertex v)
        {
            throw new NotImplementedException();
        }
    }
}
