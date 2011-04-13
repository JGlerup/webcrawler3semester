using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebCrawler
{
    public partial class Form1 : Form
    {
        public string url;
        public TreeNode mainNode;

        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Text { get; set; }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            url = tbxUrl.Text.ToString();
            mainNode = new TreeNode();

            Vertex mainVertex = new Vertex(url);

            List<Vertex> localVertices = new List<Vertex>();
                
            localVertices = (List<Vertex>)bfSearchRecursive(mainVertex);
            
            mainNode.Name = "mainNode";
            mainNode.Text = "Main: " +url;
            this.treeView.Nodes.Add(mainNode);

            webBrowser.Navigate(url); 
        }

        private System.Collections.IList bfSearchRecursive(Vertex v)
        {
            BasicGraph basicGraph = new BasicGraph();

            List<Vertex> vertices = new List<Vertex>();

            vertices = (List<Vertex>)basicGraph.BreadthFirstSearch(v);

            return vertices;
        }
    }
}
