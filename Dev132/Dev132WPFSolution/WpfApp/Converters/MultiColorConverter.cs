using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp.Converters
{
    public class MultiColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {



            byte redcolor = (byte)(double.Parse(values[0].ToString()));
            byte greencolor = (byte)(double.Parse(values[1].ToString()));
            byte bluecolor = (byte)(double.Parse(values[2].ToString()));

            Color color = new Color();
            color.R = redcolor;
            color.G = greencolor;
            color.B = bluecolor;

            return new SolidColorBrush(color);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
