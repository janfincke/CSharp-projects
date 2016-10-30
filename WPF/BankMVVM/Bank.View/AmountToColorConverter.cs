using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Bank.View
{
   class AmountToColorConverter : IValueConverter
   {
      public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
      {
         //try to cast the value to a double
         try
         {
            double castedValue = (double)value;

            if ( castedValue <= 0 )
            {
               return new SolidColorBrush ( Colors.Red );
            }
            return new SolidColorBrush( Colors.Green );
         }
         catch
         {
            return new SolidColorBrush( Colors.Red );
         }
      }

      public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
      {
         throw new NotImplementedException();
      }
   }
}
