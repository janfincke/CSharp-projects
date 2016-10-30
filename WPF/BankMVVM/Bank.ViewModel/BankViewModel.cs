using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace Bank.ViewModel
{
   public class BankViewModel : ViewModelBase
   {
      private BankAccount account;

      public BankViewModel()
      {
         account = new BankAccount() { HolderName = "John", DateOfBirth = DateTime.UtcNow - TimeSpan.FromDays( 8000 ), Amount = 25000 };
      }


      //private string m_HoldersName;
      public string HoldersName
      {
         get
         {
            return account.HolderName;
         }
         set
         {
            if( account.HolderName == value )
            {
               return;
            }

            account.HolderName = value;
            RaisePropertyChanged( "HoldersName" );
         }
      }


      //private DateTime m_HoldersBirthDate;
      public DateTime HoldersBirthDate
      {
         get
         {
            return account.DateOfBirth;
         }
         set
         {
            if( account.DateOfBirth == value )
            {
               return;
            }

            account.DateOfBirth = value;
            RaisePropertyChanged( "HoldersBirthDate" );
         }
      }


      //private double m_HoldersAmount;
      public double HoldersAmount
      {
         get
         {
            return account.Amount;
         }
         set
         {
            if( account.Amount == value )
            {
               return;
            }

            account.Amount = value;
            RaisePropertyChanged( "HoldersAmount" );
         }
      }


      private RelayCommand m_MakePayment;
      public RelayCommand MakePayment
      {
         get
         {
            if( m_MakePayment == null )
            {
               m_MakePayment = new RelayCommand(
                  () =>
                  {
                     HoldersAmount -= 5000;
                  },
                  () =>
                  {
                     if ( HoldersAmount > 0 )
                     {
                        return true;
                     }
                     else
                     {
                        return false;
                     }
                  } );
            }

            return m_MakePayment;
         }
      }
   }
}
