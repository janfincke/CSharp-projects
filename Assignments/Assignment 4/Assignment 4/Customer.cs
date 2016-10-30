using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Customer
    {
        public string Name;
        public string City;
        public Order[] Orders;
        
        public Customer(string Name, string City)
        {
            this.Name = Name;
            this.City = City;
        }

        
    }
}
