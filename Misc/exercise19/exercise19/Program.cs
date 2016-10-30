using ownMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ownMethod
{
    public static class StringExtension
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}

namespace exercise19a
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloString = "Hello, Extension Methods!";
            int wordCount = helloString.WordCount();
            Console.WriteLine(wordCount);
        }
    }
}
