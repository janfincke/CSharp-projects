using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Via.Async.FromASYNC
{
   class Program
   {
      static string Url = "http://www.jp.dk";

      static void Main( string[] args )
      {
         TraditionalAPM();
         // TaskBasedAPM();

         Console.ReadLine();
      }

      #region Traditional Asynchronous Programming Model (APM)

      static void TraditionalAPM()
      {
         HttpWebRequest request = WebRequest.Create( Url ) as HttpWebRequest;
         request.BeginGetResponse( Callback, request );
      }

      static void Callback( IAsyncResult iar )
      {
         HttpWebRequest request = iar.AsyncState as HttpWebRequest;
         HttpWebResponse response = request.EndGetResponse( iar ) as HttpWebResponse;

          // Console.WriteLine( response.StatusCode );
          var sr = new StreamReader(response.GetResponseStream());
          Console.WriteLine( sr.ReadToEnd() );
        }

      #endregion

      #region Asynchronous Programming Model (APM) via Tasks

      static async void TaskBasedAPM()
      {
         HttpWebRequest request = WebRequest.Create( Url ) as HttpWebRequest;
         HttpWebResponse response =
            await Task<WebResponse>.Factory.FromAsync(
               request.BeginGetResponse, 
               request.EndGetResponse, 
               request )
            as HttpWebResponse;

         // Console.WriteLine( response.StatusCode );
            var sr = new StreamReader(response.GetResponseStream());
            Console.WriteLine( sr.ReadToEnd() );
        }

        #endregion
    }
}
