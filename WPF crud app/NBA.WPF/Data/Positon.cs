// <copyright file="Positon.cs" company="PlaceholderCompany">
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
    /// The position of the PLayer of the View Model.
    /// </summary>
    public enum Positon
    {
        /// <summary>
        /// Position center for the Player.
        /// </summary>
        C,

        /// <summary>
        /// Position power forward for the Player.
        /// </summary>
        PF,

        /// <summary>
        /// Position small forward for the Player.
        /// </summary>
        SF,

        /// <summary>
        /// Position point guard for the Player.
        /// </summary>
        PG,

        /// <summary>
        /// Position shooting guard for the Player.
        /// </summary>
        SG,
    }
}
