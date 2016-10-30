using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Kim", "Jesper", "Mads", "Morten", "Rasmus" };

            //PREDICATE DELEGATE
            string[] sortedNames = Array.FindAll(names, sortThese);
            Console.WriteLine(sortedNames);
        }
        static bool sortThese(string val)
        {
            return val.Length > 3;
        }
    }
    
}

