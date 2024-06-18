using Fitness_App.Getfitcode;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Fitness_App
{
   
    public class EmptyTextToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int textLength)
            {
                return textLength == 0 ? Visibility.Visible : Visibility.Collapsed;
            }
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
