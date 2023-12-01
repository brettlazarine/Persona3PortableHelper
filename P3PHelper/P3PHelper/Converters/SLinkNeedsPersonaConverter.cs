using System.Globalization;

namespace P3PHelper.Converters
{
    public class SLinkNeedsPersonaConverter : IValueConverter
    {
        // Convert from SQLite int to bool => string for Label
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var needsPersona = (bool)value;
            if (needsPersona)
            {
                return "A Persona IS required for faster rank-ups!";
            }
            else
            {
                return "A Persona is NOT required for faster rank-ups, but you can use one if you would like.";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
