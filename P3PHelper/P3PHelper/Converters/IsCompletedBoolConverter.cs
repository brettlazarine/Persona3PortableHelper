using System.Globalization;

namespace P3PHelper.Converters
{
    public class IsCompletedBoolConverter : IValueConverter
    {
        // Convert from int to bool for CheckBoxes
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value == 1;
        }

        // Convert from bool to int for SQLite
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? 1 : 0;
        }
    }
}
