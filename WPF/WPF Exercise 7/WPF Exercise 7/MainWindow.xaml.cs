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

namespace WPF_Exercise_7
{
    public class Name : System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler
        PropertyChanged;

        public Name(string fName, string lName)
        {
            mFirstName = fName;
            mLastName = lName;
        }

        string mFirstName;
        string mLastName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
                PropertyChanged(this,
                new System.ComponentModel.PropertyChangedEventArgs("FirstName"));
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
                PropertyChanged(this,
                new System.ComponentModel.PropertyChangedEventArgs("LastName"));
            }
        }
    }
    public class Names : System.Collections.ObjectModel.ObservableCollection<Name>
    {
        public Names()
        {
            Name aName = new Name("FirstName " + (this.Count + 1).ToString(),
            "LastName " + (this.Count + 1).ToString());
            this.Add(aName);
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Names myNames;
        System.ComponentModel.ICollectionView aView;
        public MainWindow()
        {
            InitializeComponent();
            Names myNames;
            System.ComponentModel.ICollectionView aView;
            myNames = (Names)(this.Resources["myNames"]);
            aView = CollectionViewSource.GetDefaultView(myNames);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (!(aView.CurrentPosition == 0))
                aView.MoveCurrentToPrevious();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (!(aView.CurrentPosition == myNames.Count - 1))
                aView.MoveCurrentToNext();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Name aName = new Name("", "");
            myNames.Add(aName);
            aView.MoveCurrentToNext();
        }
    }
}
