using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ViewModel
{
   public class ViewModelLocator
   {
      private static BankViewModel bankVm = new BankViewModel();

      public BankViewModel MainPage
      {
         get { return bankVm; }
      }
   }
}
