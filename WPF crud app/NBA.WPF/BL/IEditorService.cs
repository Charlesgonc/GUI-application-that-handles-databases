// <copyright file="IEditorService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NBA.WPF.Data;

    /// <summary>
    /// The Editor Service interface.
    /// </summary>
    public interface IEditorService
    {
        /// <summary>
        /// The declaration of the method to verify the Edit of a player.
        /// </summary>
        /// <param name="player">The player that we would like to edit.</param>
        /// <returns>Bool value.</returns>
        bool EditPlayer(PlayerNBA player);
    }
}
