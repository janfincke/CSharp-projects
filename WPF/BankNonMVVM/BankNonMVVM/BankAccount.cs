using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankNonMVVM
{
   class BankAccount : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;


      private string m_Name;
      public string Name
      {
         get
         {
            return m_Name;
         }
         set
         {
            if( m_Name == value )
            {
               return;
            }

            m_Name = value;
            OnPropertyChanged( "Name" );
         }
      }

      private DateTime m_DateOfBirth;
      public DateTime DateOfBirth
      {
         get
         {
            return m_DateOfBirth;
         }
         set
         {
            if( m_DateOfBirth == value )
            {
               return;
            }

            m_DateOfBirth = value;
            OnPropertyChanged( "DateOfBirth" );
         }
      }


      private double m_Amount;
      public double Amount
      {
         get
         {
            return m_Amount;
         }
         set
         {
            if( m_Amount == value )
            {
               return;
            }

            m_Amount = value;
            OnPropertyChanged( "Amount" );
         }
      }


      private ICommand m_MakePaymentCommand;
      public ICommand MakePaymentCommand
      {
         get
         {
            if( m_MakePaymentCommand == null )
            {
               m_MakePaymentCommand = new PaymentCommand();
            }

            return m_MakePaymentCommand;
         }
      }


      //Create the OnPropertyChanged method to raise the event
      protected void OnPropertyChanged( string name )
      {
         PropertyChangedEventHandler handler = PropertyChanged;
         if( handler != null )
         {
            handler( this, new PropertyChangedEventArgs( name ) );
         }
      }
   }
}
