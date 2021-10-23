// <copyright file="HeightToStringConverter.cs" company="PlaceholderCompany">
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
    /// The height to string converter.
    /// </summary>
    public class HeightToStringConverter : IValueConverter
    {
        // VM => UI
        // double => string

        /// <summary>
        /// Conversts the double value into the displayed string.
        /// </summary>
        /// <param name="value">The dobule value to be converted.</param>
        /// <param name="targetType">Target type.</param>
        /// <param name="parameter">object parameter.</param>
        /// <param name="culture"> culture info.</param>
        /// <returns>The string conversion of the double value.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double h = (double)value * 100;
            return string.Format("{0}m {1}cm", (int)h / 100, (int)h % 100);
        }

        // UI => VM
        // string => double

        /// <summary>
        /// Conversts back the string value from the displayed string to the double value.
        /// </summary>
        /// <param name="value">The value to be converted.</param>
        /// <param name="targetType">Target type.</param>
        /// <param name="parameter">Object parameter.</param>
        /// <param name="culture">Culture Info.</param>
        /// <returns>The double value converted.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] input = value.ToString().Split(' ');
            double m = int.Parse(input[0].Substring(0, input[0].Length - 1));
            double cm = int.Parse(input[1].Substring(0, input[1].Length - 2));
            return m + cm / 100;
        }
    }
}
