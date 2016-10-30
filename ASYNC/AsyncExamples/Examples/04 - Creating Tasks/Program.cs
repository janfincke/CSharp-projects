using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Via.Async.Tasks
{
   class Program
   {
      static void Main( string[] args )
      {
         Task task1 = new Task( Method1 );

         Task task2 = new Task( delegate
                                {
                                   Console.WriteLine( "Hello from task2 ({0})", System.Threading.Thread.CurrentThread.ManagedThreadId );
                                }
         );
         Task task3 = new Task(() => Console.WriteLine("Hello from task3 ({0})", System.Threading.Thread.CurrentThread.ManagedThreadId));

            #region more
            //Task task4 = new Task(() => Console.WriteLine("Hello from task4 ({0})", System.Threading.Thread.CurrentThread.ManagedThreadId));
            //Task task5 = new Task(() => Console.WriteLine("Hello from task5 ({0})", System.Threading.Thread.CurrentThread.ManagedThreadId));
            //Task task6 = new Task(() => Console.WriteLine("Hello from task6 ({0})", System.Threading.Thread.CurrentThread.ManagedThreadId));
            //Task task7 = new Task(() => Console.WriteLine("Hello from task7 ({0})", System.Threading.Thread.CurrentThread.ManagedThreadId));
            //Task task8 = new Task(() => Console.WriteLine("Hello from task8 ({0})", System.Threading.Thread.CurrentThread.ManagedThreadId));
            //Task task9 = new Task(() => Console.WriteLine("Hello from task9 ({0})", System.Threading.Thread.CurrentThread.ManagedThreadId));

         task1.Start();
         task2.Start();
         task3.Start();
            //task4.Start();
            //task5.Start();
            //task6.Start();
            //task7.Start();
            //task8.Start();
            //task9.Start();
            #endregion

            Console.ReadLine();
      }

      static void Method1()
      {
         Console.WriteLine("Hello from task1 ({0})", System.Threading.Thread.CurrentThread.ManagedThreadId);
      }
   }
}
