using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiscLinq
{
   class Customer
   {
      public Customer(string name, string country, string city)
      {
         Name = name;
         Country = country;
         City = city;
      }
      public string Name;
      public string Country;
      public string City;
   }


   class Program
   {
      static void Main(string[] args)
      {
         #region Customer declaration
         Customer[] Customers = new Customer[] 
         {
            new Customer( "Kim",     "Denmark", "Aarhus" ),
            new Customer( "Kurt",    "Denmark", "Aarhus" ),
            new Customer( "Jesper",  "Denmark", "Horsens" ),
            new Customer( "Kaj",     "Denmark", "Vejle" ),
            new Customer( "Desiree", "France",  "Paris" ),
            new Customer( "Jean",    "France",  "Paris" ),
            new Customer( "Paul",    "France",  "Paris" ),
            new Customer( "Bobby",   "England", "London" ),
            new Customer( "Liam",    "England", "London" ),
         };

         System.Console.WriteLine("\nPrinting ALL Customers from List\n ");
         ObjectDumper.Write(Customers);
         foreach (Customer c in Customers)
         {
             System.Console.WriteLine("{0}  {1}   {2}", c.Name, c.Country, c.City);
         }
         
         #endregion

         #region no LINQ

         List<string> londoners = new List<string>();
         foreach (Customer c in Customers)
         {
             if (c.City == "London")
             {
                 londoners.Add(c.Name);
             }
         }

         foreach (var s in londoners)
         {
             Console.WriteLine("I am a Londoner: " + s);
         }

         #endregion
         
         #region ex1
         //System.Console.WriteLine("\nPrinting Customers from France\n ");

         var query =
             from c in Customers
             where c.Country == "France"
             select c;

         //ObjectDumper.Write(query);

         foreach (Customer c in query)
         {
             System.Console.WriteLine("{0}  {1}   {2}", c.Name, c.Country, c.City);
         }
         //#endregion

         //#region ex2
         //System.Console.WriteLine("\nPrinting Customers from France\n ");

         //var query2 = Customers.Where(c => c.Country == "France")
         //                      .Select(c => new { c.Name, c.Country, c.City });

         //ObjectDumper.Write(query2);
         #endregion

         #region ex3
         //System.Console.WriteLine("\nPrinting Customers from France (Ordered)\n ");

         var query3 =
             from c in Customers
             where c.Country == "France"
             orderby c.Name
             select c;

         foreach (var item in query3)
         {
             Console.WriteLine(item.Name);
         }

         ObjectDumper.Write(query3);
         #endregion

         #region ex4
         //System.Console.WriteLine("\nPrinting Customers from France (Ordered - new objects)\n ");

         var query4 =
             from c in Customers
             where c.Country == "France"
             orderby c.Name
             select new Customer(c.Name, c.Country, c.City);

         ObjectDumper.Write(query4);

         foreach (Customer c in query4) // OK because query returns Customer objects
         {
             System.Console.WriteLine("{0}  {1}   {2}", c.Name, c.Country, c.City);
         }
         #endregion

         #region ex5
         //System.Console.WriteLine("\nPrinting Customers from France (Ordered - new with anonomyous)\n ");

         //var queryFR =
         //    from c in Customers
         //    where c.Country == "France"
         //    orderby c.Name
         //    select new { c.Name, c.Country, c.City, test = "hello" };

         //foreach (var c in queryFR)
         //{
         //   System.Console.WriteLine("{0}  {1} {2} {3}", 
               
         //      c.Name, c.City, c.Country, c.test );
         //}
         
         // queryFR.ToList();



         //var queryDK =
         //    from c in Customers
         //    where c.Country == "Denmark"
         //    orderby c.Name
         //    select new { c.Name, c.Country, c.City };

         //var queryUK =
         //    from c in Customers
         //    where c.Country == "England"
         //    orderby c.Name
         //    select new { c.Name, c.Country, c.City };

         //Console.WriteLine( "Lets print it all out ");
         //Console.WriteLine( "Start with France" );


         //foreach ( var c in queryDK )
         //{
         //   System.Console.WriteLine("{0}  {1} {2} ", c.Name, c.City, c.Country);
         //}

         //foreach ( var c in queryUK )
         //{
         //   System.Console.WriteLine("{0}  {1} {2} ", c.Name, c.City, c.Country);
         //}


         //ObjectDumper.Write( query5 );
         //foreach ( Customer c in query5 ) // Compile error because of anonymous class, NOT customer
         //{
         //   System.Console.WriteLine("{0}  {1} {2} ", c.Name, c.City, c.Country);
         //}

         //foreach (var c in query5) // Anonymous class returned
         //{
         //   System.Console.WriteLine("{0}  {1}", c.Name, c.City );
         //}

         #endregion
         #region ex6
         //System.Console.WriteLine("\nPrinting Customers from France (Ordered - new with Filter method)\n ");

         var query6 =
             from c in Customers
             where Filter(c)
             orderby c.Name
             select new { c.Name, c.Country, c.City };

         //ObjectDumper.Write(query6);
         #endregion

         #region ex7
         //System.Console.WriteLine("\nPrinting Customers from Denmark (new with Filter delegate)\n ");

         //Func<Customer, bool> filter = delegate(Customer c) { return c.Country == "Denmark"; };

         //var query7 = Customers
         //            .Where(filter)
         //            .Select(p => new { p.Name, p.Country, p.City });

         //ObjectDumper.Write(query7);
         #endregion

         #region ex8
         //System.Console.WriteLine("\nPrinting Customers from France and Denmark\n ");

         //var query8 = Customers
         //   .Where(c => { return (c.Country == "France" || c.Country == "Denmark"); })
         //   .ToArray();
         //ObjectDumper.Write(query8);
         #endregion

         #region ex9
         System.Console.WriteLine("\nPrinting Customers from France (ToArray)\n ");

         var query9 = Customers
            .Where( c => c.Country == "France")
            .ToArray();

         ObjectDumper.Write(query9);
         #endregion

         #region ex10
         System.Console.WriteLine("\nPrinting Customers from France starting with J\n ");

         //var query10 = Customers.Where(c => c.Country == "France").Where(c => c.Name.StartsWith("J"));

         var query10 = from c in Customers
                       where c.Name.StartsWith("J")
                       orderby c.Name
                       select new { c.Name, c.Country, c.City };

         //ObjectDumper.Write(query10);


         var q = Customers
                 .Where(c => c.Name.StartsWith("J"))
                 .OrderBy(c => c.Name)
                 .Select(c => new { c.Name, c.Country, c.City });
         ObjectDumper.Write(q);
         #endregion

         System.Console.ReadKey();
      }

      static bool Filter(Customer c)
      {
         return c.Country == "France";
      }
   }
}
