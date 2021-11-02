using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MemeMaker.Convertidores
{
    class ConvierteBoolGrosor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => (bool)value ? 0 : 5;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => (bool)value ? 5 : 0;
    }
}
