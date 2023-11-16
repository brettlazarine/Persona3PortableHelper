using P3PHelper.MVVM.ViewModels;
using P3PHelper.MVVM.Views.SLinks;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3PHelper.Converters
{
    public class ResponseStackConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //var val = (bool)value;
            var vm = new InteractionStoryViewModel();
            var arrow = vm.ArrowRotated;
            return arrow;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
