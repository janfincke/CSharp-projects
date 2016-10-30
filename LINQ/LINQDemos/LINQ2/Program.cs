using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ2
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] scores = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

         Console.WriteLine("All scores");
         Console.WriteLine("Average = {0}", scores.Average());
         Console.WriteLine("Max     = {0}", scores.Max() );
         Console.WriteLine("Min     = {0}", scores.Min() );

         Console.WriteLine( "Only for passing scores");

         double avg = (from score 
                       in scores 
                       where score >= 60 
                       select score).Average();


         double min = (from score in scores where score >= 60 select score).Min();
         double max = (from score in scores where score >= 60 select score).Max();

         Console.WriteLine("Average = {0}", avg);
         Console.WriteLine("Max     = {0}", max);
         Console.WriteLine("Min     = {0}", min);
         
         Console.ReadKey();
      }
   }
}
