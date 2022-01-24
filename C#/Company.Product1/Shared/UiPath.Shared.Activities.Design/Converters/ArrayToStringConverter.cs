using System;
using System.Globalization;
using System.Windows.Data;

namespace UiPath.Shared.Activities.Design.Converters
{
    public class ArrayToStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var stringArray = Array.ConvertAll<object, string>(values[0] as object[], ConvertObjectToString);
            // Use string Join to concatenate the string elements.
            var result = string.Join(", ", stringArray);
            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            //  Can't convert back, don't try. 
            throw new NotImplementedException();
        }

        private static string ConvertObjectToString(object obj)
        {
            return obj?.ToString() ?? string.Empty;
        }
    }
}
