using System;
using System.Linq;
using System.Text.RegularExpressions;                                                   // added the regular expressions to the using statement and removed all unnecessary statements

namespace LINQ_Exercise_1
{

    class Program
    {
        static void A()
        {
            var names = new[] { "Kim", "Kurt", "Karsten", "Klaus", "Kay" };             // declare new array to store names

            var result = from name in names                                             // use LINQ to query the elements and then replace the letter K with C and store them in a var
                         select name.Replace("K","C");

            Console.WriteLine("Results of A:");
            foreach (var item in result)
            {
                Console.WriteLine(item);                                                // iterate over the LINQ query results and write new elements to console
            }
        }
        static void B()
        {
            var names = new[] { "Kim", "Kurt", "Karsten", "Klaus", "Kay" };             // declare new array to store names
            var vowels = new Regex("a|e|i|o|u|y|ä|ö", RegexOptions.IgnoreCase);         // I decided to use regular expressions to select all vowels from the string,
                                                                                        // just to make things a little straight forward
            var vwls = from vowel in names                                              
                       select vowels.Replace(vowel, string.Empty);                      // use LINQ to make a query from the names array, then replace the letters that contain vowels
                                                                                        // with an empty string

            Console.WriteLine("Results of B:");                                         
            foreach(var item in vwls)
            {
                Console.WriteLine(item);                                                // iterate over the query results and write the new and replaced elements to console
            }
        }
        static void Main(string[] args)
        {
            A();
            B();                                                                        // calling functions from the main program
        }
    }
}
