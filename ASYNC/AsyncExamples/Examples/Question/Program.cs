using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Via.Async.Question
{
   class Program
   {
      static string _text = "";

      static void Main( string[] args )
      {
         WebRequest request = WebRequest.Create( "http://www.jp.dk" );
         WebResponse r = request.GetResponse();
         
         GetLine( r );

         Console.WriteLine( _text );

         Console.ReadKey();
      }

      public static async void GetLine( WebResponse r )
      {
         var sr = new StreamReader( r.GetResponseStream() );
         _text = await sr.ReadLineAsync();
      }
   }
}
