using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankNonMVVM
{
   public class PaymentCommand : ICommand
   {
      public event EventHandler CanExecuteChanged;

      public bool CanExecute( object parameter )
      {
         if( parameter is BankAccount )
         {
            BankAccount b = (BankAccount)parameter;
            return !( b.Amount <= 0 );
         }
         return true;
      }

      public void Execute( object parameter )
      {
         BankAccount bankAccount = (BankAccount)parameter;
         bankAccount.Amount -= 5000;

         OnCanExecuteChanged();
      }

      private void OnCanExecuteChanged()
      {
         if( CanExecuteChanged != null )
         {
            CanExecuteChanged( this, new EventArgs() );
         }
      }
   }
}
