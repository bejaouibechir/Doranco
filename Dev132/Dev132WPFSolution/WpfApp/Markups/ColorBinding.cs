using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;

namespace WpfApp.Markups
{
    public class ColoringBinding : MarkupExtension
    {
        public ColoringBinding()
        {

        }
        public ColoringBinding(SolidColorBrush coloring)
        {
            Coloring = coloring;
        }

        public SolidColorBrush Coloring { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Coloring;
        }
    }

}
