// <copyright file="PlayerNBA.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight;

    /// <summary>
    /// The VM player class.
    /// </summary>
    public class PlayerNBA : ObservableObject
    {
        private int playerId;
        private int playerAge;
        private int playerSalary;
        private double playerHeight;
        private double playerWeight;
        private double playerFieldGoal;
        private string playerName;
        private Status playerStatus;
        private Positon playerPosition;
        private DateTime playerDraftDate;

        /// <summary>
        /// Gets or sets the value for the id of the VM calss.
        /// </summary>
        public int PlayerId
        {
            get { return this.playerId; }
            set { this.Set(ref this.playerId, value); }
        }

        /// <summary>
        /// Gets or sets the value for the name of the VM player class.
        /// </summary>
        public string PlayerName
        {
            get { return this.playerName; }
            set { this.Set(ref this.playerName, value); }
        }

        /// <summary>
        /// Gets or sets and Sets the value for the age of the VM player class.
        /// </summary>
        public int PlayerAge
        {
            get { return this.playerAge; }
            set { this.Set(ref this.playerAge, value); }
        }

        /// <summary>
        /// Gets or sets and Sets the value for the height of the VM player class.
        /// </summary>
        public double PlayerHeight
        {
            get { return this.playerHeight; }
            set { this.Set(ref this.playerHeight, value); }
        }

        /// <summary>
        /// Gets or sets and Sets the value for the weight of the VM player class.
        /// </summary>
        public double PlayerWeight
        {
            get { return this.playerWeight; }
            set { this.Set(ref this.playerWeight, value); }
        }

        /// <summary>
        /// Gets or sets and Sets the value for the field goal of the VM player class.
        /// </summary>
        public double PlayerFieldGoal
        {
            get { return this.playerFieldGoal; }
            set { this.Set(ref this.playerFieldGoal, value); }
        }

        /// <summary>
        /// Gets or sets and Sets the value for the salary of the VM player class.
        /// </summary>
        public int PlayerSalary
        {
            get { return this.playerSalary; }
            set { this.Set(ref this.playerSalary, value); }
        }

        /// <summary>
        /// Gets or sets and Sets the value for the draft date of the VM player class.
        /// </summary>
        public DateTime PlayerDraftDate
        {
            get { return this.playerDraftDate; }
            set { this.Set(ref this.playerDraftDate, value); }
        }

        /// <summary>
        /// Gets or sets and Sets the value for the position of the VM player class.
        /// </summary>
        public Positon PlayerPosition
        {
            get { return this.playerPosition; }
            set { this.Set(ref this.playerPosition, value); }
        }

        /// <summary>
        /// Gets or sets and Sets the value for the position of the VM player class.
        /// </summary>
        public Status PlayerStatus
        {
            get { return this.playerStatus; }
            set { this.Set(ref this.playerStatus, value); }
        }

        /// <summary>
        /// The Player VM class's Copy Method.
        /// </summary>
        /// <param name="otherPlayer"> The other player.</param>
        public void CopyFrom(PlayerNBA otherPlayer)
        {
            this.GetType().GetProperties().ToList().ForEach(p => p.SetValue(this, p.GetValue(otherPlayer)));
        }
    }
}
