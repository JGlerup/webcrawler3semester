using System;
using System.Collections.Generic;


namespace Noea.Http
{
	/// <summary>
	/// Interface to classes that encapsulates connection to a server using a TCP socket.
	/// The intention is to use the HTTP protocol, but other protocols might be used as well.
	/// </summary>
	/// 


	public interface IHttp
	{
		/// <summary>
		/// Gets a value indicating whether a Socket is connected to a remote host.
		/// </summary>
		/// <value>true if the socket is connected, otherwise false</value>>
        //bool IsConnected {get;}

		/// <summary>
		/// Gets or sets the timeout value for sending and receiving. 
		/// If the the timeout value is exceeded an exception should be thrown
		/// </summary>
		/// <value>The timeout period in millisecs</value>
		int TimeOut{get;set;}

		/// <summary>
		/// Opens the connection to the server.
		/// Pre:	The server can be reached by the url and portnumber
		/// Post:	Connection etablished
		/// </summary>
		/// <param name="url">Identification of the server. i.e a dns name or a ip address</param>
		/// <param name="port">Number between 1 and 65335, default 80</param>
		string Open(string url);

		/// <summary>
		/// Closes the connection to server. 
		/// </summary>
		void Close();

		/// <summary>
		/// Sends a request to the server, i.e by using http
		/// Pre:	A connection is etablished to the server
		/// Post:	A request is sent to the server
		/// </summary>
		/// <param name="command">the request, i.e "GET /index.html"</param>
		void Send(string command);

		/// <summary>
		/// Receives the response from the server
		/// Pre:	A request has been sent to the server, and IsConnected is still true
		/// Post:	The response is returned in a string
		/// </summary>
		/// <returns>the response from the server</returns>
		List<string> Receive(string url, string inputText);

		/// <summary>
		/// Gets a stream object to the server object, that might be used for common stream operations.
		/// Pre:	A connection is etablished to the server
		/// Post:	A stream object is returned, i.e a NetworkStream object.
		/// </summary>
		/// <returns>a stream object</returns>
		System.IO.Stream GetStream();

		/// <summary>
		/// Tests a http connection by sending "GET / HTTP/1.1\r\nHost: " + url + "\r\nConnection: Close\r\n\r\n"
		/// Pre:	The server can be reached by the url and portnumber
		/// Post:	A response from the server is received
		/// </summary>
		/// <param name="url">Identification of the server. i.e a dns name or a ip address</param>
		/// <param name="port">Number between 1 and 65335, default 80</param>
		/// <returns>the response from the server</returns>
		String ConnectionTest(string url);
	}


}
