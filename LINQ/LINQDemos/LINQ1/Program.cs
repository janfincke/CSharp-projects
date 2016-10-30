using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ1
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] scores = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
         /*System.Collections.Generic.IEnumerable<int>*/
         var passingScores = from s in scores
                             where s >= 60
                             select s;

         foreach (var item in passingScores)
         {
            Console.WriteLine("Passing score: {0}", item);
         }


         Console.WriteLine("Printing the average of the result using above");
         Console.WriteLine(passingScores.Average());

         Console.WriteLine("Printing the average of the result - direct");
         Console.WriteLine((from score in scores
                            where score >= 60
                            select score).Average());

         
         Console.ReadKey();
      }
   }
}
