using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VIA.DataLibrary
{
   public class Student : INotifyPropertyChanged
   {
      #region Properties

      static Uri ImageNotAvailableUri
      {
         get
         {
            return new Uri("pack://application:,,,/VIA.DataLibrary;component/nophoto.gif");
         }
      }

      public string FullName
      {
         get
         {
            return (FirstName ?? "") + " " + (LastName ?? "");
         }
      }

      public string LastName
      {
         get
         {
            return _lastName;
         }
         set
         {
            _lastName = value;
             NotifyPropertyChanged("LastName");
             NotifyPropertyChanged("FullName");
         }
      }
      private string _lastName;

      public string FirstName
      {
         get
         {
            return _firstName;
         }
         set
         {
            _firstName = value;
            NotifyPropertyChanged("FirstName");
           NotifyPropertyChanged("FullName");
         }
      }
      private string _firstName;

      public string Company
      {
         get
         {
            return _company;
         }
         set
         {
            _company = value;
         //   NotifyPropertyChanged("Company");
         }
      }
      private string _company;

      public Uri ImageUri 
      {
         get
         {
            return _imageUri;
         }
         set
         {
            _imageUri = value;
            NotifyPropertyChanged("ImageUri");
         }
      }
      private Uri _imageUri;
      #endregion
   
      #region Constructors

        public Student()
            : this(
                "Foged",
                "Kim",
                "DSE Airport Solutions A/S",
                new Uri("pack://application:,,,/VIA.DataLibrary;component/KF.jpg"))
        {
        }

        public Student( string lastName, string firstName, string company )
            : this(
                lastName,
                firstName,
                company,
                ImageNotAvailableUri )
        {
        }

        public Student(string lastName, string firstName, string company, Uri imageUri)
        {
            LastName = lastName;
            FirstName = firstName;
            Company = company;
            ImageUri = imageUri;

            #region Set random favorite modules
            //int j = 1;
            //FavoriteModules = new List<Module>();
            //Random random = new Random( ( lastName + FirstName ).Length );
            //for( int i = 0; i < 3; i++ )
            //{
            //    j += 1 + random.Next( 3 );

            //    FavoriteModules.Add( new Module { Title = "Module " + j } );
            //}
            #endregion
        }

        #endregion  
 
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
           PropertyChangedEventHandler del = PropertyChanged;
           if (del != null)
           {
              del(this, new PropertyChangedEventArgs(propertyName));
           }
        }

        #endregion
   }
}
