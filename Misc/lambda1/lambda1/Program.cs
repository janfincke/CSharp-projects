using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string[] names = { "Kim", "Jesper", "Mads", "Morten", "Rasmus" };          

            // ANONYMOUS METHOD
            string[] sortedNames = Array.FindAll( names, delegate(string val)
            {
               return val.Length > 3;
            });       
            Console.WriteLine(string.Join(", ", sortedNames));          
        }
    }
}
