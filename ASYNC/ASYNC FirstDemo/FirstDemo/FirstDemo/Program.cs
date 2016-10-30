using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;

namespace FirstDemo
{
   public class Test
   {
      // Three things to note in the signature: 
      //  - The method has an async modifier.  
      //  - The return type is Task or Task<T>. (See "Return Types" section.)
      //    Here, it is Task<int> because the return statement returns an integer. 
      //  - The method name ends in "Async."
      public async Task<int> AccessTheWebAsync()
      {
         // You need to add a reference to System.Net.Http to declare client.
         HttpClient client = new HttpClient();

         // GetStringAsync returns a Task<string>. That means that when you await the 
         // task you'll get a string (urlContents).
         Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

         // You can do work here that doesn't rely on the string from GetStringAsync.
         DoIndependentWork();

         // The await operator suspends AccessTheWebAsync. 
         //  - AccessTheWebAsync can't continue until getStringTask is complete. 
         //  - Meanwhile, control returns to the caller of AccessTheWebAsync. 
         //  - Control resumes here when getStringTask is complete.  
         //  - The await operator then retrieves the string result from getStringTask. 
         string urlContents = await getStringTask;

         // The return statement specifies an integer result. 
         // Any methods that are awaiting AccessTheWebAsync retrieve the length value. 
         return urlContents.Length;
      }

      void DoIndependentWork()
      {
         for (int i = 0; i < 1000; i++)
         {
            Console.Write("x");
            if (i % 25 == 0)
            {
               Console.WriteLine();
            }
         }
      }

      public async void TestTheStuff()
      {
         int count_bytes = await AccessTheWebAsync();

         Console.WriteLine("Total of {0} bytes downloaded ({1})", count_bytes, Thread.CurrentThread.ManagedThreadId );
       
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Start in main ({0})", Thread.CurrentThread.ManagedThreadId);

         Test test = new Test();
         test.TestTheStuff();

         Console.WriteLine();
         Console.WriteLine("End in main ({0})", Thread.CurrentThread.ManagedThreadId);
         Console.ReadKey();
      }
   }
}
