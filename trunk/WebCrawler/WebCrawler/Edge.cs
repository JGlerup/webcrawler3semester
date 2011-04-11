using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler
{
    class Edge
    {
        private Vertex startVertex;
        private Vertex endVertex;

        public Edge(Vertex startVertex, Vertex endVertex)
        {
            this.startVertex = startVertex;
            this.endVertex = endVertex;
        }

        internal Vertex StartVertex
        {
            get { return startVertex; }
            set { startVertex = value; }
        }

        internal Vertex EndVertex
        {
            get { return endVertex; }
            set { endVertex = value; }
        }
    }
}
