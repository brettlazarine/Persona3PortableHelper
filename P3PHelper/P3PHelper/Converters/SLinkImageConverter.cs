using System.Globalization;

namespace P3PHelper.Converters
{
    public class SLinkImageConverter : IValueConverter
    {
        // Convert a string to a path for the image, accommodate for Hanged Man
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var name = value.ToString().ToLower();
            if (name is "hanged man")
            {
                return "hangedman";
            }
            else
            {
                return name;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
