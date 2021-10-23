// <copyright file="IMainLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPFprog4hf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// MainLogic interface.
    /// </summary>
    public interface IMainLogic
    {
        /// <summary>
        /// Definition of Get Ones method.
        /// </summary>
        /// <returns>PLayer.</returns>
        public PlayerVM ExecuteGetOnes();

        /// <summary>
        /// Definition of Select method.
        /// </summary>
        /// <param name="id">id of player to be selected.</param>
        public void SelectLogic(int id);

        /// <summary>
        /// Definition of Unselect method.
        /// </summary>
        /// <param name="id">Id of the player to be unselected.</param>
        public void UnselectLogic(int id);

        /// <summary>
        /// Definition of the method to delete player.
        /// </summary>
        /// <param name="id">id of the player to be deleted.</param>
        public void DeleteOne(int id);
    }
}
