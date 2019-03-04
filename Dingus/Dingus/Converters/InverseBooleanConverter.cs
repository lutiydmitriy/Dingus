﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Dingus.Converters
{
    class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => !((bool)value);
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => !((bool)value);
    }
}
