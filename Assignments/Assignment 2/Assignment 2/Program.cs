using System;
using System.Collections.Generic;

namespace Assignment_2
{
    // Delegate types to describe predicates on ints and actions on ints.
    public delegate bool IntPredicate(int x);
    public delegate void IntAction(int x);
    // Integer lists with Act and Filter operations.
    // An IntList containing the element 7 9 13 may be constructed as
    // new IntList(7, 9, 13) due to the params modifier.
    class IntList : List<int>
    {
        public IntList(params int[] elements) : base(elements)
        {
        }
        //Further, use anonymous methods to write an expression that prints only those list elements that are
        //greater than or equal to 25.
        public IntList GreaterThan(IntPredicate p)
        {
            IntList result = new IntList();
            foreach (int i in this)           
                if (i >= 25)               
                    result.Add(i);                           
            return result;
        }
        public void Act(IntAction f)
        {
            foreach (int i in this)            
                f(i);                     
        }
        public IntList Filter(IntPredicate p)
        {
            IntList res = new IntList();
            foreach (int i in this)
                if (p(i))
                    res.Add(i);
            return res;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            IntList xs = new IntList(7, 9, 13, 20, 25, 26, 28, 30, 1, 2, 3);
            
            xs.Filter(delegate (int x) { return x % 2 == 0; }).Act(Console.WriteLine);
            //Explain what goes on above: How many IntList are there in total, including xs?
               // There are a total of 3 IntLists in play on this line of code. 
                // One inside the Filter method (declared res as an IntList), then the Filter method itself (which is basically a list of lists).
                // Then we declare xs as an IntList again in the Main program.
            
            xs.GreaterThan(delegate (int x) { return x == 0; }).Act(Console.WriteLine);
        }
    }
}
