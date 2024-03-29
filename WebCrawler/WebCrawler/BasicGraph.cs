﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Noea.Http;

namespace WebCrawler
{
    class BasicGraph : IBasicGraph
    {
        private IList<Vertex> vertices;
        private List<Vertex> dfSearch;
        private List<Vertex> bfSearch;
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

        public void UnmarkAll()
        {
            foreach (Vertex v in vertices)
            {
                v.Mark = false;
            }
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
            return vertices.Contains(vertex);
        }

        public bool IsAdjacent(Vertex startVertex, Vertex endVertex)
        {
            return FindEdge(startVertex, endVertex) == null;
        }
        
        public System.Collections.IList GetAdjacencies(Vertex vertex)
        {
            List<Vertex> localVerticies = new List<Vertex>();

            foreach (Vertex v in vertices)
            {
                if (v == vertex)
                {
                    foreach (Edge edge in edges)
                    {
                        localVerticies.Add(edge.EndVertex);
                    }
                }
            }

            return localVerticies;
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
            v.Mark = true;

            dfSearch = new List<Vertex>();

            foreach (Vertex vertex in GetAdjacencies(v))
            {
                dfSearch.Add(v);
                if (!vertex.Mark)
                {
                    DepthFirstSearch(vertex);
                }
            }
            return dfSearch;
        }

        public System.Collections.IList breadthFirstSearch(string url)
        {
            string responseData = "";
            List<Vertex> queue = new List<Vertex>();
            List<string> linksFromSite = new List<string>();
            IHttp http = new HttP();

            Vertex localVertex = new Vertex(url);
            responseData = http.Open(url);
            http.Close();
            linksFromSite = http.Receive(url, responseData);
            int count = linksFromSite.Count;
            
            while (count > 0)
            {
                if (localVertex.Mark == false)
	            {
		            localVertex.Mark = true;

                    foreach (var item in linksFromSite)
	                {
                        Vertex v = new Vertex(item);
                        count--;
                        queue.Add(v);
	                }
	            }
            }
            return queue;
        }
    }
}
