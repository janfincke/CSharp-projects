using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VIA.ASync.Await
{
   class Program
   {
      static void Main( string[] args )
      {
         Console.WriteLine( $"Thread id is {Thread.CurrentThread.ManagedThreadId}");

         DoStuff();
            
         Console.BackgroundColor = ConsoleColor.DarkGray;

         Console.ReadLine();
      }

      async static void DoStuff()
      {
         Console.WriteLine($"Thread id is {Thread.CurrentThread.ManagedThreadId}");

         string url = "http://www.jp.dk";

         WebClient client = new WebClient();
         string result = await client.DownloadStringTaskAsync( url );

         Console.WriteLine($"Thread id is {Thread.CurrentThread.ManagedThreadId}");

         Console.WriteLine( result );
      }
   }
}
