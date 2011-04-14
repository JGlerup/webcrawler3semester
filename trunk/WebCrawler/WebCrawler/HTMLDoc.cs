using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Noea.Html;
using System.Text.RegularExpressions;

namespace WebCrawler
{
    public class HTMLDoc : IHTMLDoc
    {

        public string Document
        {
            get { throw new NotImplementedException(); }
        }

        public string URL
        {
            get { throw new NotImplementedException(); }
        }

        public bool Contains(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
