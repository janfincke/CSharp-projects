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

namespace Wincubate.Module13.Slide15
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      private async void OnClick( object sender, RoutedEventArgs e )
      {
         lblResult.Content = await FactorAsync(); 
      }

      private async Task<string> FactorAsync()
      {
         int number = int.Parse( txtNumber.Text );

         return await Task.Factory.StartNew<string>( () =>
            string.Join( "*", PrimeHelper.GetPrimeFactors( number ) )
         );
      }
   }
}
