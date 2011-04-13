using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Noea.Html;
using System.Text.RegularExpressions;

namespace WebCrawler
{
    class HTMLDoc : IHTMLDoc
    {

        public string Document
        {
            get { throw new NotImplementedException(); }
        }

        public string URL
        {
            get { throw new NotImplementedException(); }
        }

        public System.Collections.IList GetAllLinks()
        {

            Regex MyRegex = new Regex("href.*?\"(?<href>.*?)\"", RegexOptions.Multiline); 
            MatchCollection mc1 = MyRegex.Matches(s);
            Console.WriteLine(MyRegex.ToString());
            foreach (Match m1 in mc1)
            {
                Console.WriteLine("URL: {0}", m1.Groups["href"].Value);
            }

            //List<string> links = new List<string>();
            //MatchCollection matches = Regex.Matches(Html, "href.*?\"(?<href>.*?)\"", RegexOptions.IgnoreCase);
            //foreach (Match match in matches)
            //{
            //    links.Add(match.Groups["href"].ToString());
            //}

            //return links;

            //}
        }

        public bool Contains(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
