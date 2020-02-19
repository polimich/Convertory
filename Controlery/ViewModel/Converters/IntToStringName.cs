using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Controlery.ViewModel.Converters
{
    class IntToStringName : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is int)
            {
                int cislo = ((int)value) % 7;
                switch (cislo)
                {
                    case 0: { return "Kámen"; }
                    case 1: { return "Nůžky"; }
                    case 2: { return "Papír"; }

                }
            }
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value is string && targetType == typeof(string))
            {
                switch (value)
                {
                    case "Nůžky": { return 1; }
                    case "Papír": { return 2; }
                    default: return "Kámen";
                }
            }
            return value.ToString();
        }
    }
}
