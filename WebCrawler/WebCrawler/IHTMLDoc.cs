using System;
using System.Collections;

namespace Noea.Html
{
	/// <summary>
	/// Interface to classes that encapsulate a HMTL document
	/// </summary>
	public interface IHTMLDoc
	{

		/// Implementing classes could contain a constructor like this:
		/// xxxHTMLDoc(string url);
		/// gets a network connection (socket/http)and retrieve the web page
		/// indicated by url and store the content.
		/// Urls are assummed to be unique.
		/// That is: an url is the absolute address of a page.
		
		string Document{get;}
		/// read-only property. Returns the web page as a string.

		string URL{get;}
		/// read-only. Returns the URL of the current web-page

        //IList GetAllLinks();
		/// Returns a list of strings containing the urls
		/// of all links to pages on the this site.
		/// That is: links to web pages outside this are not included

		bool Contains(string searchString);
		/// returns true if searchString is found in <body>...</body>
		/// in this HTML-document


//	This method migth be the one that talks to the network via a socket connection
// 		private string GetHTML(string url)
//		{	// Dummy implementation:
//			return "<!DOCTYPE HTML PUBLIC \"-//IETF//DTD HTML//EN\"> <html> <head> <META NAME=\"Generator\" CONTENT=\"Stone's WebWriter 3.5\"> <meta http-equiv=\"Content-Type\" content=\"text/html; iso-8859-1\"><!-- Minus AutoDato --><title>main</title><meta name=\"FORMATTER\" content=\"Microsoft FrontPage 2.0\"></head><frameset rows=\"17%,83%\" cols=\"17%,83%\"><frame src=\"logo.htm\" name=\"Logo\" scrolling=\"no\"><frame src=\"efterudd.htm\" name=\"efterudd\" scrolling=\"no\"><frame src=\"menu.htm\" name=\"menu\" noresize><frame src= \"php3/kursusliste.php3?aktuelle\"  name=\"text\"><noframes><body><p><!--webbot bot=\"PurpleText\"preview=\"The frameset on this page can be edited with the FrontPage Frames Wizard; use the Open or Open With option from the FrontPage Explorer's edit menu. This page must be saved to a web before you can edit it with the Frames Wizard. Browsers that don't support frames will display the contents of this page, without these instructions. Use the Frames Wizard to specify an alternate page for browsers without frames.\" s-viewable=\" \" --> </p> <p>This web page uses frames, but your browser doesn't support them.</p></body></noframes></frameset></html>";
//
//		}
	}
}
