﻿namespace WarehouseManagementDesktopApp.Core.ValueConverter
{
    namespace MyApp.Tools
    {

        public class RatioConverter : BaseValueConverter<RatioConverter>
        {

            public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            { // do not let the culture default to local to prevent variable outcome re decimal syntax
                double size = System.Convert.ToDouble(value) * System.Convert.ToDouble(parameter, CultureInfo.InvariantCulture);
                return size.ToString("G0", CultureInfo.InvariantCulture);
            }

            public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            { // read only converter...
                throw new NotImplementedException();
            }

        }
    }
}
