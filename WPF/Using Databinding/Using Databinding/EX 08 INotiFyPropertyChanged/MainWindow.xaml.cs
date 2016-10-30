using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VIA.DataLibrary;

namespace VIA
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      Student _student = new Student();

      public MainWindow()
      {
         InitializeComponent();

         DataContext = _student;
      }

      private void btnModify_Click(object sender, RoutedEventArgs e)
      {
         _student.FirstName = "Mario";
         _student.ImageUri =  new Uri("pack://application:,,,/VIA.DataLibrary;component/JGH.jpg");
      }
   }
}
