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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;

namespace Assignment_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Timers.Timer timer;

        private Random rand = new Random();

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // initializing a timer to track execution time
            timer = new System.Timers.Timer();
            timer.Interval = 8000; // 8 seconds
            timer.Enabled = true; // make timer able to raise events
            timer.Elapsed += new ElapsedEventHandler(onTimedEvent); // make a new event to process what happens after 8 seconds
            timer.Start(); // start timer when button is pressed

            testMethod(); // run tasks
        }

        public async Task testMethod()
        {
            label.Content = "Operation started...";
            // starting 3 tasks
            var task1 = HeavyWorkAsync();
            var task2 = HeavyWorkAsync();
            var task3 = HeavyWorkAsync();
            
            await Task.WhenAll(task1, task2, task3); // wait for all tasks to finish       
            label.Content = "Operation completed.";
            
            timer.Stop(); 
        }

        
        public void onTimedEvent(object sender, ElapsedEventArgs e)
        {
            // I needed a Dispatcher to separate the UI updating because trying to directly change the label content resulted in an error.
            // I'm using Invoke to execute the ChangeText synchronously.
            Dispatcher.Invoke(ChangeText);
        }

        public void ChangeText()
        {
            this.label.Content = "Operation still running...";
        }
        
        #region Exercise functions
        public void HeavyWork()
        {
            double secondsToSleep = rand.NextDouble() * 10;
            Thread.Sleep(TimeSpan.FromSeconds(secondsToSleep));
        }
        public Task HeavyWorkAsync()
        {
            return Task.Run(() => HeavyWork());
        }
        #endregion
    }
}
    