// <copyright file="PlayerListViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// The view model of the playerLsit.
    /// </summary>
    public class PlayerListViewModel
    {
        /// <summary>
        /// Gets or sets the edited player.
        /// </summary>
        public Player EditedPLayer { get; set; }

        /// <summary>
        /// Gets or sets the list of the players.
        /// </summary>
        public List<Player> ListOfPlayers { get; set; }
    }
}
