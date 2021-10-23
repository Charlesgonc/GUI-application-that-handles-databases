// <copyright file="Status.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The enum that defines the satus of a player.
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// The status of a player that is active.
        /// </summary>
        Active,

        /// <summary>
        /// The status of a player that is Injured.
        /// </summary>
        Injured,

        /// <summary>
        ///  The status of a player that on offseason.
        /// </summary>
        Unactive,
    }
}
