using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a)
            // a) Using the new C# 3.0 feature ”Object Initializers” to instantiate the following 3 customers:
            //      1) Kim Foged, Beder having 3 orders of the products Milk, Butter and Bread
            //      2) Ib Havn, Horsens having 4 orders of the products Milk, Butter, Bread and Cacao
            //      3) Rasmus Bjerner, Horsens having 1 order of the product Juice
            List<Customer> customers = new List<Customer>
            {
                    new Customer("Kim Foged", "Beder")
                    {
                        Orders = new Order[]
                        {
                            new Order { Product = new Product("Milk", 10), Quantity = 1 },
                            new Order { Product = new Product("Butter", 5), Quantity = 2 },
                            new Order { Product = new Product("Bread", 15), Quantity = 3 }
                        }
                    },

                    new Customer("Ib Havn", "Horsens")
                    {
                        Orders = new Order[]
                        {
                            new Order { Product = new Product("Milk", 10), Quantity = 100 },
                            new Order { Product = new Product("Butter", 5), Quantity =  165},
                            new Order { Product = new Product("Bread", 15), Quantity = 750 },
                            new Order { Product = new Product("Cacao", 20), Quantity = 1000 },
                        }
                    },

                    new Customer("Rasmus Bjerner", "Horsens")
                    {
                        Orders = new Order[]
                        {
                            new Order { Product = new Product("Juice", 20), Quantity = 50 },
                        }
                    }

            };
            #endregion

            #region b)
            // b) Write a LINQ query to select all customers. Print the Name and City of each customer
            //    in the query.

            //var allCustomers = from x in customers
            //                   select new { x.Name, x.City };


            //foreach (var i in allCustomers) Console.WriteLine(i);

            #endregion

            #region c)
            // c) Write a LINQ query to select all customers from Horsens.Print the Name of each customer
            //    in the query.

            //var customersHorsens = from x in customers
            //                       where x.City == "Horsens"
            //                       select x.Name ;

            //foreach (var i in customersHorsens) Console.WriteLine(i);

            #endregion

            #region d)
            // d) Write a LINQ query to select the count of orders for the customer Ib Havn.Print the number

            //var ibOrdersCount = (from customer in customers
            //                    from order in customer.Orders
            //                    where customer.Name == "Ib Havn"
            //                    select order).Count().ToString();

            //foreach (var i in ibOrdersCount) Console.WriteLine(i);

            #endregion

            #region e)
            // e) Write a LINQ query to select all customers buying milk. Print the Name of each customer
            //    in the query

            //var buyingMilk = from customer in customers
            //                 from order in customer.Orders
            //                 where order.Product.Name == "Milk"
            //                 select customer.Name;

            //foreach (var i in buyingMilk) Console.WriteLine(i);

            #endregion

            #region f)
            // f) Write a LINQ query to select the total sum(prices of products in Orders) from each customer.
            //    Print the Name and Sum of each customer in the query.

            //var sumFromProducts = (from customer in customers
            //                       from order in customer.Orders
            //                       let total = order.Product.Prices
            //                       select new
            //                       {
            //                           customer.Name,
            //                           total = customer.Orders.Sum(_ => _.Product.Prices)

            //                       }).Distinct();

            //foreach (var i in sumFromProducts) Console.WriteLine(i);

            #endregion

            #region g)
            // g) Write a LINQ query to select the total sum(All customers sum added). Print the result.
            
            //var sumOfAll = (from customer in customers
            //                from order in customer.Orders
            //                select order.Product.Prices).Sum();
                            
            //Console.WriteLine("Total sum of prices for all customers: " + sumOfAll);

            #endregion
        }
    }
}
