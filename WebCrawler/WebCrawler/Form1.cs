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

        //public TreeNode mainNode;

        //public int ID { get; set; }
        //public int ParentID { get; set; }
        //public string Text { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            url = tbxUrl.Text.ToString();

            //mainNode = new TreeNode();
            //mainNode.Name = "mainNode";
            //mainNode.Text = "Main: " +url;
            //this.treeView.Nodes.Add(mainNode);

            webBrowser.Navigate(url);

            List<Vertex> localVertices = new List<Vertex>();

            addNode(localVertices);
        }

        private void addNode(List<Vertex> foundLinks)
        {
            foundLinks = (List<Vertex>)bfSearch(url);

            int count = Convert.ToInt32(tbDebth.Text);

            Dictionary<Vertex, List<Vertex>> d = new Dictionary<Vertex, List<Vertex>>(); 

            List<string> adresses = new List<string>();

            int foundLinksCount = foundLinks.Count;

            while (count > 0 || foundLinksCount > 0)
            {
                foreach (var item in foundLinks)
                {
                    string site = item.Url.ToString();

                    TreeNode parentNode = new TreeNode(site);
                    this.treeView.Nodes.Add(parentNode);
                    
                    List<Vertex> localLinks = (List<Vertex>)bfSearch(site);

                    foreach (var decendantItem in localLinks)
                    {
                        string decendantSite = decendantItem.Url.ToString();

                        TreeNode decendantNode = new TreeNode(decendantSite);
                        
                        this.treeView.Nodes.Add(decendantSite);
                    }
                    count--;
                    foundLinksCount--;
                }
            }

            
        }

        private System.Collections.IList bfSearch(string url)
        {
            BasicGraph basicGraph = new BasicGraph();

            List<Vertex> vertices = new List<Vertex>();

            vertices = (List<Vertex>)basicGraph.breadthFirstSearch(url);

            return vertices;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }
    }
}
