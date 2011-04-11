using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler
{
    class Vertex
    {
        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        private bool mark;

        public bool Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public Vertex(string url)
        {
            mark = false;
            this.url = url;
        }

        public override string ToString()
        {
            return url + " " + mark;
        }
    }
}
