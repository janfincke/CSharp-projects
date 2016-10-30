using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public struct Pair<T, U>        // declared new generic struct type Pair
    {
        public readonly T first;
        public readonly U second;
        public Pair(T fst, U snd)
        {
            first = fst;
            second = snd;
        }
        public override String ToString()
        {
            return "(" + first + ", " + second + ")";
        }
        // h) Declare a method Swap() in Pair<T,U> that returns a new struct value of type Pair<U,T> in
        //    which the components have been swapped.
        public Pair<U, T> Swap()        
        {
            return new Pair<U, T>(second, first);
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            // b) Declare a variable of type Pair<String, int> and create some values, for instance
            //    new Pair<String, int>("Kurt", 13), and assign them to the variable.
            Pair<string, int> myName = new Pair<string, int>("Jan", 23);

            // c) Declare a variable of type Pair<String, double>. Create a value such as
            //    new Pair<String, double>("Phoenix", 39.7) and assign it to the variable.
            Pair<string, double> phoenix = new Pair<string, double>("Phoenix", 39.7);

            // d) Can you assign a value of type Pair<String,int> to a variable of type Pair<String,double>?


            // Pair<string, int> riddle = new Pair<string, double>("", 39);

            //    Should this be allowed? 

            // e) Declare a variable grades of type Pair<String,int>[ ], create an array of length 5 with element
            //    type Pair< String,int> and assign it to the variable. (This shows that in C#, the element type of an
            //    array may be a type instance.) Create a few pairs and store them into grades[0], grades[1] and
            //    grades[2].
            Pair<string, int>[] grades = new Pair<string, int>[5];
            
            grades[0] = new Pair<string, int>("Jan", 2);
            grades[1] = new Pair<string, int>("Nico", 3);
            grades[2] = new Pair<string, int>("Kim", 4);


            // f) Use the foreach statement to iterate over grades and print all its elements. What are the
            //    values of those array elements you did not assign anything to ?
            foreach (var j in grades)
            {
                Console.WriteLine(j);   // unassigned array elements show up as (, 0) in console
            }

            // g) Declare a variable appointment of type Pair<Pair<int,int>,String>, and create a value of
            //    this type and assign it to the variable. What is the type of appointment.Fst.Snd? This shows that
            //    a type argument may itself be a constructed type.
            Pair<Pair<int, int>, string> appointment = new Pair<Pair<int, int>, string>(
                new Pair<int,int>(23, 23), 
                "Jan");

            // h) Testing Swap() method
            Pair<string, int> myName2 = new Pair<string, int>("Jan", 23);
            Console.WriteLine(myName2.Swap());
        }
    }
}
