﻿using System;
using System.Globalization;

using Sample.Services;

using Xamarin.Forms;

namespace Sample.Converters
{
    public class ExceptionToErrorMessageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var exception = value as Exception;

            if (value == null)
            {
                return null;
            }

            return ApplicationExceptions.ToString(exception);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // One-Way converter only
            throw new NotImplementedException();
        }
    }
}
