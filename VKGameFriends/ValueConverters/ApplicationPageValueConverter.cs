using System;
using System.Diagnostics;
using System.Globalization;

namespace VKGameFriends
{
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((ApplicationPage)value)
            {
                default: Debugger.Break(); return null;
                case ApplicationPage.Login: return new LoginPage();
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
