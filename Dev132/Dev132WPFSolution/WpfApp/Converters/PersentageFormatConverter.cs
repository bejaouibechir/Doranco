using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp.Converters
{
    internal class PersentageFormatConverter : IValueConverter
    {
        //Conersion double ->  chaine  %
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double input = (double)value;
            string output = $"{Math.Ceiling(input)} %";
            return output;
        }

        //Conersion    chaine ->  % double 20%
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return double.Parse(value.ToString().Replace("%",string.Empty));
        }
    }
}
