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
using System.Threading.Tasks;
using System.Diagnostics;

namespace Via.Async.ParallelTest
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

        private void btnParallel_Click( object sender, RoutedEventArgs e )
        {
            #region Parallel.Invoke()

            //Action action1 = () =>
            //{
            //    for (int i = 0; i < 100; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //};

            //Action action2 = () =>
            //{
            //    for (int i = 1; i < 100; i += 2)
            //    {
            //        Console.WriteLine("\t" + i);
            //    }
            //};

            //Action action3 = () =>
            //{
            //    for (int i = 0; i > -100; i -= 2)
            //    {
            //        Console.WriteLine("\t\t" + i);
            //    }
            //};

            //Parallel.Invoke(action1, action2, action3);

            #endregion

            #region Parallel.For()
            //Parallel.For(0, 1000, i =>
            //     Console.WriteLine(string.Format("Executing number {0,4}...", i)
            //     )
            // );
            #endregion

            #region Parallel.ForEach()
            //IEnumerable<int> list = Enumerable.Range(0, 1000);
            //Parallel.ForEach(list, i =>
            //    Console.WriteLine(string.Format("Executing number {0,4}...", i)
            //    )
            // );
            #endregion

            #region Parallel.ForEach() using the Dispatcher
            IEnumerable<int> list = Enumerable.Range(0, 1000);
            Parallel.ForEach(list, i => Dispatcher.BeginInvoke(
                                                new Action<string>(AddToListBox),
                                                string.Format("{0,4}", i)
               )

             // AddToListBox(string.Format("{0,4}", i))
             );
            #endregion
        }

        private void AddToListBox( string s )
        {
            lstResults.Items.Add( s );
        }
    }
}
