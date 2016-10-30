using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Kim", "Mads", "Morten", "Jesper", "Rasmus" };
            string[] sortedNames = names.OrderBy( i => i ).ToArray();
            Console.WriteLine(string.Join(", ", sortedNames));
        }
    }
}
