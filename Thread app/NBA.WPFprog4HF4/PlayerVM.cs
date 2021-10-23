// <copyright file="PlayerVM.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPFprog4hf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight;

    /// <summary>
    /// PLayer vm.
    /// </summary>
    public class PlayerVM : ObservableObject
    {
        private int playerId;
        private int playerAge;
        private int playerSalary;
        private double playerHeight;
        private double playerWeight;
        private double playerFieldGoal;
        private string playerName;
        private string playerPosition;
        private DateTime playerDraftDate;
        private byte playerIsSelected;

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
        public string PlayerPosition
        {
            get { return this.playerPosition; }
            set { this.Set(ref this.playerPosition, value); }
        }

        /// <summary>
        /// Gets or sets and Sets the value for the selection of the VM player class.
        /// </summary>
        public byte PlayerIsSelected
        {
            get { return this.playerIsSelected; }
            set { this.Set(ref this.playerIsSelected, value); }
        }

        /// <summary>
        /// The Player VM class's Copy Method.
        /// </summary>
        /// <param name="otherPlayer"> The other player.</param>
        public void CopyFrom(PlayerVM otherPlayer)
        {
            this.GetType().GetProperties().ToList().ForEach(p => p.SetValue(this, p.GetValue(otherPlayer)));
        }

        /// <summary>
        /// Override to string.
        /// </summary>
        /// <returns>The string representation of this class.</returns>
        public override string ToString()
        {
            return $"ID: {this.PlayerId}, Name: {this.PlayerName}, Age: {this.PlayerAge}, Salary: {this.PlayerSalary}, Height: {this.PlayerHeight}, Weight: {this.PlayerWeight}, FieldGoal: {this.PlayerFieldGoal}, Position: {this.PlayerPosition}, DraftDate: {this.PlayerDraftDate}, IsSelected: {this.PlayerIsSelected}";
        }
    }
}
