using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ4
{
   class Program
   {
      static void Main(string[] args)
      {
        // var anonymous = new { k = 1, j = 2, l = 5 };
        // Console.WriteLine( anonymous );
        //Console.WriteLine();
        //Console.WriteLine();

     //   Console.ReadKey();


         var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

         var query = from k in list
                     let j = k + 2
                     let l = j * j
                     select new { k, j, l };

          //the let keyword was used to create two new temp variables (j, k) which their 
          //values were calculated inside the query

         foreach (var item in query)
         {
          
     
            Console.WriteLine(item);
         }

         Console.ReadKey();
      }
   }
}
