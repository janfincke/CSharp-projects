using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_Overview
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return CustomerID + "\t" + City;
        }
    }
    class Program
    {
        static void ObjectQuery()
        {
            var results = from c in CreateCustomers()
                          where c.City == "London"
                          select c;
            foreach (var c in results)
                Console.WriteLine(c);
        }
        public static void XMLQuery()
        {
            var doc = XDocument.Load("Customers.xml");
            var results = from c in doc.Descendants("Customer")
                          where c.Attribute("City").Value == "London"
                          select c;
            XElement transformedResults =
                new XElement("Londoners",
                    from customer in results
                    select new XElement("Contact",
                        new XAttribute("ID", customer.Attribute("CustomerID").Value),
                        new XElement("Name", customer.Attribute("ContactName").Value),
                        new XElement("City", customer.Attribute("City").Value)));
            Console.WriteLine("Results:\n{0}", transformedResults);
            transformedResults.Save("Output.xml");
        }
        static void Main(string[] args)
        {
            XMLQuery();
        }
        static IEnumerable<Customer> CreateCustomers()
        {
            return
                from c in XDocument.Load("Customers.xml")
                    .Descendants("Customers").Descendants()
                select new Customer
                {
                    City = c.Attribute("City").Value,
                    CustomerID = c.Attribute("CustomerID").Value
                };
        }
        static void NumQuery()
        {
            var numbers = new int[] { 1, 4, 9, 16, 25, 36 };

            var evenNumbers = from p in numbers
                              where (p % 2) == 0
                              select p;

            Console.WriteLine("Result: ");
            foreach (var val in evenNumbers)
                Console.WriteLine(val);
        }
    }
}
