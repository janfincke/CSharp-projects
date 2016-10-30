using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Exercise_3
{
    class Program
    {
        public static List<string> stringList = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h" };            // declare a new List of type string
        
        static void Main(string[] args)
        {
            var oneGroup = (from i in stringList
                                select i).Take(3);

            var twoGroup = (from i in stringList
                              select i).Skip(3).Take(3);                                                                // here I iterate through the list and use the Take and Skip methods to
                                                                                                                        // pick specific strings from the list
            var threeGroup = (from i in stringList
                              select i).Skip(6).Take(2);           

            foreach(var item in oneGroup)
            {
                Console.Write(item);
            }
            Console.Write("\n");
            foreach (var item in twoGroup)
            {
                Console.Write(item);                                                                                    // write groups on their own lines in the console
            }
            Console.Write("\n");
            foreach (var item in threeGroup)
            {
                Console.Write(item);
            }
            Console.Write("\n");
        }
    }
}
