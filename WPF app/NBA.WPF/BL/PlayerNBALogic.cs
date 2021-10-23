// <copyright file="PlayerNBALogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GalaSoft.MvvmLight.Messaging;
    using NBA.Data;
    using NBA.WPF.Data;

    /// <summary>
    /// The implementation of the interface IPLayerNBALogic.
    /// </summary>
    public class PlayerNBALogic : IPlayerNBALogic
    {
        private IEditorService editorService;
        private IMessenger messenger;
        private ConectorWithDatabase conector;

        // private static int id;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerNBALogic"/> class.
        /// </summary>
        /// <param name="editorService"> IEditorService.</param>
        /// <param name="messenger"> IMessenger.</param>
        /// <param name="conector">Conector class.</param>
        public PlayerNBALogic(IEditorService editorService, IMessenger messenger, ConectorWithDatabase conector)
        {
            this.editorService = editorService;
            this.messenger = messenger;
            this.conector = conector;
        }

        /// <summary>
        /// The implemetnation of the method to add a player to the list in the UI.
        /// </summary>
        /// <param name="list">The list where we would like to insert the player.</param>
        public void AddPlayerNBA(IList<PlayerNBA> list)
        {
            PlayerNBA player = new PlayerNBA();
            if (this.editorService.EditPlayer(player) == true)
            {
                Player playerClone = new Player()
                {
                    PlayerId = player.PlayerId,
                    PlayerName = player.PlayerName,
                    PlayerAge = player.PlayerAge,
                    PlayerDraftDate = player.PlayerDraftDate,
                    PlayerFieldGoal = player.PlayerFieldGoal,
                    PlayerHeight = player.PlayerHeight,
                    PlayerPosition = player.PlayerPosition.ToString(),
                    PlayerSalary = player.PlayerSalary,
                    PlayerWeight = player.PlayerWeight,
                };

                this.conector.TeamManagerLogic.InsertPlayer(playerClone);
                list.Add(player);
                this.messenger.Send("ADD OK", "LogicResult");
            }
            else
            {
                this.messenger.Send("ADD CANCELED", "LogicResult");
            }
        }

        /// <summary>
        /// The implemetnation of the method to delete a player to the list in the UI.
        /// </summary>
        /// <param name="list">The list from where we want to delete the player.</param>
        /// <param name="player">The player that we would like to delete.</param>
        public void DeletePlayerNBA(IList<PlayerNBA> list, PlayerNBA player)
        {
            if (player != null && list.Remove(player))
            {
                IList<Player> players = this.conector.TeamManagerLogic.GetAllPlayers();
                foreach (Player p in players)
                {
                    if (p.PlayerId == player.PlayerId)
                    {
                        this.conector.TeamManagerLogic.RemovePlayer(p);
                    }
                }

                this.messenger.Send("DELETION SUCCESSFUL", "LogicResult");
            }
            else
            {
                this.messenger.Send("DELETION FAILED", "LogicResult");
            }
        }

        /// <summary>
        /// The method to edit a player from the list in the UI.
        /// </summary>
        /// <param name="playerToEdit">THe player that we would like to edit.</param>
        public void EditPlayerNBA(PlayerNBA playerToEdit)
        {
            if (playerToEdit == null)
            {
                this.messenger.Send("EDIT FAILED", "LogicResult");
                return;
            }

            PlayerNBA playerClone = new PlayerNBA();
            playerClone.CopyFrom(playerToEdit);

            if (this.editorService.EditPlayer(playerClone) == true)
            {
                playerToEdit.CopyFrom(playerClone);

                Player player = new Player()
                {
                    PlayerName = playerToEdit.PlayerName,
                    PlayerAge = playerToEdit.PlayerAge,
                    PlayerDraftDate = playerToEdit.PlayerDraftDate,
                    PlayerFieldGoal = playerToEdit.PlayerFieldGoal,
                    PlayerHeight = playerToEdit.PlayerHeight,
                    PlayerPosition = playerToEdit.PlayerPosition.ToString(),
                    PlayerSalary = playerToEdit.PlayerSalary,
                    PlayerWeight = playerToEdit.PlayerWeight,
                    PlayerId = playerToEdit.PlayerId,
                };

                // create on the the repo a function changefull >> called from the logic and then called here.
                this.conector.NbaSecretaryLogic.FullPlayerUpdateLogic(playerToEdit.PlayerId, player);
                this.messenger.Send("EDIT SUCCESSFUL", "LogicResult");
            }
            else
            {
                this.messenger.Send("EDIT FAILED", "LogicResult");
            }
        }

        /// <summary>
        /// Gets all the players in the database.
        /// </summary>
        /// <returns>The list of the players in the database.</returns>
        public IList<PlayerNBA> GetAllPlayersNBA()
        {
            IList<PlayerNBA> playerNBAList = new List<PlayerNBA>();
            IList<Player> playersList = this.conector.TeamManagerLogic.GetAllPlayers();

            foreach (Player player in playersList)
            {
                PlayerNBA p = new PlayerNBA()
                {
                    PlayerName = player.PlayerName,
                    PlayerAge = player.PlayerAge,
                    PlayerDraftDate = player.PlayerDraftDate,
                    PlayerFieldGoal = player.PlayerFieldGoal,
                    PlayerHeight = player.PlayerHeight,
                    PlayerId = player.PlayerId,
                    PlayerSalary = player.PlayerSalary,
                    PlayerWeight = player.PlayerWeight,
                    PlayerPosition = Getback(player.PlayerPosition),
                };

                playerNBAList.Add(p);
            }

            return playerNBAList;
        }

        private static Positon Getback(string s)
        {
            if (s == Positon.C.ToString())
            {
                return Positon.C;
            }
            else if (s == Positon.PF.ToString())
            {
                return Positon.PF;
            }
            else if (s == Positon.PG.ToString())
            {
                return Positon.PG;
            }
            else if (s == Positon.SF.ToString())
            {
                return Positon.SF;
            }

            return Positon.SG;
        }
    }
}
