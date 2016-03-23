using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfHeatMap.BindIngConvert
{
    class ConvertTest : IValueConverter
    {
        public object Convert(object o, Type type, object parameter, CultureInfo culture)
        {
            string i = (string)o;
            if (i == "0")
                return "男";
            else
                return "女";
        }
        public object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
