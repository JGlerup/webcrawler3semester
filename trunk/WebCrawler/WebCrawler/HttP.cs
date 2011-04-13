using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Noea.Http;

namespace WebCrawler
{
    class HttP : IHttp
    {
        private WebRequest request;
        private WebResponse response;
        private StreamReader reader;

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

        public void Open(string url)
        {
		    request = WebRequest.Create(url);
		    response = request.GetResponse();
		    reader = new StreamReader(response.GetResponseStream());
        }

        public void Close()
        {
            response.Close();
            reader.Close();
        }

        public void Send(string command)
        {
            throw new NotImplementedException();
        }

        public string Receive()
        {
            throw new NotImplementedException();
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
