// <copyright file="EditorViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.VM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight;
    using NBA.WPF.Data;

    /// <summary>
    /// The editor window for the selected player.
    /// </summary>
    public class EditorViewModel : ViewModelBase
    {
        /// <summary>
        /// The player instance to be edited.
        /// </summary>
        private PlayerNBA player;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorViewModel"/> class.
        /// </summary>
        public EditorViewModel()
        {
            this.player = new PlayerNBA();
            if (this.IsInDesignMode)
            {
                this.player.PlayerName = "Unknown";
                this.player.PlayerAge = 18;
                this.player.PlayerFieldGoal = 50.0;
                this.player.PlayerHeight = 1.75;
                this.player.PlayerId = 1;
                this.player.PlayerPosition = Positon.PG;
                this.player.PlayerSalary = 50000;
                this.player.PlayerWeight = 64.5;
                this.player.PlayerStatus = Status.Active;
                this.player.PlayerDraftDate = DateTime.Now;
            }
        }

        /// <summary>
        /// Gets or sets the current player to be edited.
        /// </summary>
        public PlayerNBA Player
        {
            get { return this.player; }
            set { this.Set(ref this.player, value); }
        }

        /// <summary>
        /// Gets the Position of the current player to be edited.
        /// </summary>
        public Array Positions
        {
            get { return Enum.GetValues(typeof(Positon)); }
        }

        /// <summary>
        /// Gets the current status of the player.
        /// </summary>
        public Array Statuses
        {
            get { return Enum.GetValues(typeof(Status)); }
        }
    }
}
