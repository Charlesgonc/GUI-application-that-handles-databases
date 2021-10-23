// <copyright file="Player.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Form model of the Player // The class that we will use to display Players ( MVC view model ).
    /// Responsible for imputting a Player and displaying a Player ( violates the single responsability principle ).
    /// </summary>
    public class Player
    {
        // being a form model (appart from the props ) we need validation rules and form addictional display data.

        /// <summary>
        /// Gets or Sets the Id of the player.
        /// </summary>
        [Display(Name =" Player Id")]
        [Required]
        public int PlayerId { get; set; }

        /// <summary>
        /// Gets or Sets the Age of the player.
        /// </summary>
        [Display(Name = " Player Age")]
        [Required]
        public int PlayerAge { get; set; }

        /// <summary>
        /// Gets or Sets the Salary of the player.
        /// </summary>
        [Display(Name = " Player Salary")]
        [Required]
        public int PlayerSalary { get; set; }

        /// <summary>
        /// Gets or Sets the Height of the player.
        /// </summary>
        [Display(Name = " Player Height")]
        [Required]
        public double PlayerHeight { get; set; }

        /// <summary>
        /// Gets or Sets the Weight of the player.
        /// </summary>
        [Display(Name = " Player Weight")]
        [Required]
        public double PlayerWeight { get; set; }

        /// <summary>
        /// Gets or Sets the FG of the player.
        /// </summary>
        [Display(Name = " Player FG")]
        [Required]
        public double PlayerFieldGoal { get; set; }

        /// <summary>
        /// Gets or Sets the Name of the player.
        /// </summary>
        [Display(Name = " Player Name")]
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string PlayerName { get; set; }

        /// <summary>
        /// Gets or Sets the Positon of the player.
        /// </summary>
        [Display(Name = " Player Positon")]
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string PlayerPosition { get; set; }

        /// <summary>
        /// Gets or sets the DraftDate of the player.
        /// </summary>
        [Display(Name = " Draft Date")]
        [Required]
        public DateTime PlayerDraftDate
        {
            // get { return DateTime.Now; }
            get; set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is selected or not.
        /// </summary>
        [Display(Name = " Is Selected")]
        public byte PlayerIsSelected { get; set; }
    }
}
