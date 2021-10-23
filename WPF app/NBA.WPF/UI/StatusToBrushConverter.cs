// <copyright file="StatusToBrushConverter.cs" company="PlaceholderCompany">
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
    using System.Windows.Media;
    using NBA.WPF.Data;

    /// <summary>
    /// The converter from the status of a player to a brush background color.
    /// </summary>
    public class StatusToBrushConverter : IValueConverter
    {
        // VM => UI
        // Status => brush color

        /// <summary>
        /// Converts the status of the player to a brush color.
        /// </summary>
        /// <param name="value">The Status to be converted into the brush color.</param>
        /// <param name="targetType">The target type.</param>
        /// <param name="parameter">The parameter object.</param>
        /// <param name="culture">The culture info.</param>
        /// <returns>The converted brush color.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Status status = (Status)value;
            switch (status)
            {
                default:
                case Status.Active: return Brushes.LightGreen;
                case Status.Injured: return Brushes.Salmon;
                case Status.Unactive: return Brushes.Red;
            }
        }

        /// <summary>
        /// does nothing.
        /// </summary>
        /// <param name="value">The brush color to be converted back.</param>
        /// <param name="targetType">The target type.</param>
        /// <param name="parameter">The parameter object.</param>
        /// <param name="culture">the culture info.</param>
        /// <returns>Nothing.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
