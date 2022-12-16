using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp.Converters
{
    public class AddConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            decimal sum = 0M;

            foreach (string value in values)
            {
                decimal parseResult;
                if (decimal.TryParse(value, out parseResult))
                {
                    sum += parseResult;
                }
            }

            return sum.ToString(culture);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
