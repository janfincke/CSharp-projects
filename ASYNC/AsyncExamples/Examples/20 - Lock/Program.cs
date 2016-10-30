using System;
using System.Threading;
using System.Threading.Tasks;

namespace Via.Async.Lock
{
   class A
   {
      public int _counter = 0;

      public void MyTaskMethod()
      {
         Random r = new Random(DateTime.Now.Millisecond);

         for (int i = 0; i < 50; i++)
         {
            int temp = _counter;
            Thread.Sleep(r.Next(10));
            _counter = temp + 1;

            Console.WriteLine(
               string.Format("m_Counter = {0}. Thread: {1}",
                  _counter,
                  Thread.CurrentThread.ManagedThreadId));

            Thread.Sleep(r.Next(10));
         }

         Console.WriteLine("Task complete");
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         A a = new A();

         Task t1 = Task.Factory.StartNew( a.MyTaskMethod );
         Task t2 = Task.Factory.StartNew( a.MyTaskMethod );

         Console.ReadLine();
      }
   }
}
