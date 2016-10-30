using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
   public class BankAccount
   {
      public string HolderName
      { get; set; }

      public DateTime DateOfBirth
      { get; set; }
      
      public double Amount
      { get; set; }
   }
}
