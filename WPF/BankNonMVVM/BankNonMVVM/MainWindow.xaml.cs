using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankNonMVVM
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      BankAccount bankAccount = new BankAccount() { Name = "John", DateOfBirth = DateTime.UtcNow - TimeSpan.FromDays ( 8000 ), Amount = 25000 };
      
      public MainWindow()
      {
         InitializeComponent();

         this.DataContext = bankAccount;
      }

      //private void Button_Click( object sender, RoutedEventArgs e )
      //{
      //   //business logic and model in view code behind :(
      //   bankAccount.Amount -= 5000;

      //   if( bankAccount.Amount <= 0 )
      //   {
      //      //referencing visual element in code behind
      //      PaymentButton.IsEnabled = false;
      //      AmountLabel.Foreground = new SolidColorBrush( Colors.Red );
      //   }
      //}
   }
}
