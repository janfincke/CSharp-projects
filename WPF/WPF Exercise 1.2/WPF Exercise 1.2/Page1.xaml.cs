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

namespace WPF_Exercise_1._2
{
    /// <summary>
    /// Interaction logic for Page.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamWriter sw = new
            System.IO.StreamWriter("C:\\temp\\username.txt");
            sw.WriteLine(textBox.Text);
            sw.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader sr = new
            System.IO.StreamReader("C:\\temp\\username.txt");
            label.Content = "Hello " + sr.ReadToEnd();
            sr.Close();

        }
    }
}
