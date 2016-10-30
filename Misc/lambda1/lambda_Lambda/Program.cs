using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Kim", "Jesper", "Mads", "Morten", "Rasmus" };

            //LAMBDA EXPRESSION
            string[] sortedNames = Array.FindAll(names, (i) => i.Length > 3);
            Console.WriteLine(sortedNames);
        }
    }
}
