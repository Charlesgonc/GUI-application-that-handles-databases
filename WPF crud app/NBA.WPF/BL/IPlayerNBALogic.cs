// <copyright file="IPlayerNBALogic.cs" company="PlaceholderCompany">
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
    /// The interface that implements the CRUD operations for the player.
    /// </summary>
    public interface IPlayerNBALogic
    {
        /// <summary>
        /// The declaration of the method that I would like to add a player to the list.
        /// </summary>
        /// <param name="list">The list where we would like to insert the player.</param>
        void AddPlayerNBA(IList<PlayerNBA> list);

        /// <summary>
        /// The declaration of the method to edit the player.
        /// </summary>
        /// <param name="playerToEdit">The player that we would like to modify.</param>
        void EditPlayerNBA(PlayerNBA playerToEdit);

        /// <summary>
        /// The declaration of the method to remove a player from the list.
        /// </summary>
        /// <param name="list">The list from where we would like to remove the player.</param>
        /// <param name="player">Th eplayer that we would like to remove from the list.</param>
        void DeletePlayerNBA(IList<PlayerNBA> list, PlayerNBA player);

        /// <summary>
        /// Get all playersNBA method.
        /// </summary>
        /// <returns>Returns an IList of BirthdayServices.</returns>
        IList<PlayerNBA> GetAllPlayersNBA();
    }
}
