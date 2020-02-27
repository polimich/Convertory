﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace Controlery.ViewModel.Converters
{
    class IntToImage : IValueConverter
    {
        public BitmapImage Rock { get; set; }
        public BitmapImage Scissors { get; set; }
        public BitmapImage Paper { get; set; }
        public BitmapImage None { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is KNP)
            {
                switch ((int)value)
                {
                    case 0: { return None; }
                    case 1: { return Rock; }
                    case 2: { return Scissors; }
                    case 3: { return Paper; }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
