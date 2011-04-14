using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Noea.Http;

namespace WebCrawler
{
    class HttP : IHttp
    {
        private WebRequest request;
        private WebResponse response;
        private Stream dataStream;
        private StreamReader reader;
        private string responseData;

        //public bool IsConnected
        //{
        //    get
        //    {
        //        return true;
        //    }
            
        //}

        public int TimeOut
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Open(string url)
        {
		    request = WebRequest.Create(url);
		    response = request.GetResponse();
            dataStream = response.GetResponseStream();
		    reader = new StreamReader(dataStream);
            responseData = reader.ReadToEnd();
            return responseData;
        }

        public void Close()
        {
            reader.Close();
            dataStream.Close();
            response.Close();
            
        }

        public void Send(string command)
        {
            throw new NotImplementedException();
        }

        public List<string> Receive(string inputText)
        {
            List<string> linkList = new List<string>();
            //StringBuilder sb = new StringBuilder();  
            Regex hrefs = new Regex("<a href.*?>");  
            //Regex http = new Regex("http:.*?>");
            foreach (Match m in hrefs.Matches(inputText))
            {
                linkList.Add(m.ToString());
                m.
                //sb.Append(m.ToString());
                //if (http.IsMatch(m.ToString()))
                //{
                    //linkList.Add(http.Match(m.ToString()).ToString());
                    //sb.Append(http.Match(m.ToString()));
                    //sb.Append("<br>");
                //}
                //else
                //{
                    //linkList.Add(m.ToString().Substring(1, m.ToString().Length - 1) + "<br>");
                    //sb.Append(m.ToString().Substring(1, m.ToString().Length - 1) + "<br>");
                //}
            }
            
            //char[] listLinks1 = {};
            //sb.CopyTo(0, listLinks1, 0, sb.Length);
            //listLinks.AddRange(sb.CopyTo(0, listLinks, 0, sb.Length));
            //return sb.ToString();
            return linkList;
        }

        public System.IO.Stream GetStream()
        {
            throw new NotImplementedException();
        }

        public string ConnectionTest(string url)
        {
            //Open(url);
            //for (string line = reader.ReadLine(); line != null; )
            //  return line;  
            
            //Close();
            return url;
        }
    }
}
