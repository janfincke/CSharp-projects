using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Multimedia : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public enum MediaType
        {
            CD,
            DVD
        };
        private string _title;
        private string _artist;
        private string _genre;
        private MediaType _type;

        public string title
        {
            get { return _title; }
            set { _title = value; NotifyPropertyChanged("1"); }
        }

        public string artist
        {
            get { return _artist; }
            set { _artist = value; NotifyPropertyChanged("1"); }
        }

        public string genre
        {
            get { return _genre; }
            set { _genre = value; NotifyPropertyChanged("1"); }
        }
        
    }
}
