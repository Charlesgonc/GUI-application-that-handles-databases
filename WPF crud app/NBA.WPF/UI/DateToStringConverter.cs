// <copyright file="DateToStringConverter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.UI
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Data;

    /// <summary>
    /// Converts the DateTime to a string.
    /// </summary>
    public class DateToStringConverter : IValueConverter
    {
        // VM => UI , Date => string

        /// <summary>
        /// Converts from a DateTime to string.
        /// </summary>
        /// <param name="value">The DateTime to be converted into a string.</param>
        /// <param name="targetType">TargetType.</param>
        /// <param name="parameter">Parameter.</param>
        /// <param name="culture">CultureInfo.</param>
        /// <returns>A string convertion of the dateTime.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            return date.ToString("yyyy/MM/dd");
        }

        /// <summary>
        /// Converts back the string to the DateTime.
        /// </summary>
        /// <param name="value">the string to be converted into the dateTime.</param>
        /// <param name="targetType">Targettype.</param>
        /// <param name="parameter">Parameter.</param>
        /// <param name="culture">CultureInfo.</param>
        /// <returns>The conversion back of the string.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string date = (string)value;
            return DateTime.Parse(date);
        }
    }
}
