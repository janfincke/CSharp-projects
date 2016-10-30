using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LINQ5
{
   class Program
   {
      static void Main(string[] args)
      {
         var data = XElement.Parse(@"<data>
	                                     <customer id='1' name='Kurt' credit='100' />
	                                     <customer id='2' name='Kim'  credit='150' />
	                                     <customer id='3' name='Arne' credit='123' />
                                     </data>");

         var query = from cust in data.Elements()
                     where (int)cust.Attribute("credit") > 100
                     select cust.Attribute("name").Value;

         foreach (var item in query)
         {
            Console.WriteLine( item );
         }

         
         // return anonymous type with name and credit
         var query1 = from cust in data.Elements()
                      where (int)cust.Attribute("credit") > 100
                      select new { Name = cust.Attribute("name").Value, Credit = int.Parse(cust.Attribute("credit").Value )};

         foreach (var item in query1)
         {
            Console.WriteLine("Name={0} Credit={1}", item.Name, item.Credit);
         }
         
    
         Console.ReadKey();
      }
   }
}
