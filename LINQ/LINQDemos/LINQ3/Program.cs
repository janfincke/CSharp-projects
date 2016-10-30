using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ3
{
   public static class StringExtensionsClass    
   {      
      public static string RemoveVowels( this string s )
      {    
         StringBuilder sb = new StringBuilder();
         string Vowels = "aeiuoyæøåAEIUOYÆØÅ";

         for( int i = 0; i < s.Length; i++ )
         {

            if (Vowels.Contains(s[i]))
            {
               // skip
            }
            else
            {
               sb.Append( s[i] );
            }
         }          
         return sb.ToString();       
      }   
   }

   class Program
   {
      static void Main(string[] args)
      {
         var names = new[] { "Peter", "Nichlas", "Nando", "Patricia", "Natasja", "Ole" };

         // IEnumerable<string> 
            var query = 
                from n in names
                where n.Contains("a")    // Filter elements
                orderby n.Length         // Sort elements
                select n.ToUpper();      // Translate each element (project)

         foreach (var item in query)
         {
            Console.WriteLine( item );
         }


         #region Extension lambda version
         Console.WriteLine("Extension lambda version");

         IEnumerable<string> query1 = names
                                  .Where(n => n.Contains("a"))
                                  .OrderBy(n => n.Length)
                                  .Select(n => n.ToUpper());


         IEnumerable<string> query2 = 
            names.Where(n => n.Contains("a")).OrderBy(n => n.Length).Select(n => n.ToUpper());
         
         
         #endregion

         Console.ReadKey();
      }
   }
}
