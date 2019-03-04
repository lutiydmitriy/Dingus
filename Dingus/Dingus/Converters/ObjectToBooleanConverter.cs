﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Dingus.Converters
{
    class ObjectToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => value == null;
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;
    }
}
