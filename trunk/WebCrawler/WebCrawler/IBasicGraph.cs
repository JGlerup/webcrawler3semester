using System;
using System.Collections;
namespace WebCrawler
{	//  FEN 2005.02.16
    //	PQC 2005.04.27 Namespace changed to Noea.Graph
    /// <summary>
    /// basic graph operations on an unweighted graph are defined in this interface
    /// specification omitted when obvious
    /// </summary>
    public interface IBasicGraph
    {
        ///<summary>
        ///adds a vertex to the graph
        ///</summary>
        void AddVertex(Vertex vertex);

        ///<summary>
        ///adds an edge to the (unweighted) graph
        ///PRE (to,from) is not contained in the graph
        ///</summary>
        void AddEdge(Vertex startVertex, Vertex endVertex);

        ///<summary>
        ///removes v from the graph
        ///PRE none
        ///</summary>
        void RemoveVertex(Vertex v);

        ///<summary>
        ///removes (to,from) from the graph
        ///</summary>
        void RemoveEdge(Vertex from, Vertex to);

        ///<summary>
        ///determines whether a vertex is in the graph
        ///</summary>
        bool ContainsVertex(Vertex vertex);

        ///<summary>
        ///determines whether two vertices are adjacent
        ///</summary>
        bool IsAdjacent(Vertex startVertex, Vertex endVertex);

        ///<summary>
        ///Returns a list containing all vertices adjancent to vertex.
        ///Must be a list since it should be possible to remove adjacent vertices
        ///</summary>
        IList GetAdjacencies(Vertex vertex);

        ///<summary>
        ///Returns an Enumerator to the collection of vertices
        ///</summary>
        IEnumerator Vertices();

        ///<summary>
        ///Returns an Enumerator to the collection of edges
        ///</summary>		
        IEnumerator Edges();

        ///<summary>
        ///determines whether the graph is empty
        ///</summary>
        bool IsEmpty();

        ///<summary>
        ///returns the number of vertices
        ///</summary>
        int GetNoOfVertices();

        ///<summary>
        ///returns the number of edges
        ///</summary>
        int GetNoOfEdges();

        ///<summary>
        ///makes the graph empty
        ///</summary>
        void Clear();

        ///<summary>
        ///Returns a list of Vertices in dfs-order
        ///PRE The graph is connected and v is contained in the graph
        ///</summary>
        IList DepthFirstSearch(Vertex v);
    }
}
