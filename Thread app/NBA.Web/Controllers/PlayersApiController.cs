// <copyright file="PlayersApiController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using NBA.Logic;

    /// <summary>
    /// PlayersApiController.
    /// </summary>
    public class PlayersApiController : Controller
    {
        private ITeamManagerLogic logic1;
        private INbaSecretaryLogic logic2;

        private IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayersApiController"/> class.
        /// </summary>
        /// <param name="logic1">param1.</param>
        /// <param name="logic2">param2.</param>
        /// <param name="mapper">param3.</param>
        public PlayersApiController(ITeamManagerLogic logic1, INbaSecretaryLogic logic2, IMapper mapper)
        {
            this.logic1 = logic1;
            this.logic2 = logic2;
            this.mapper = mapper;
        }

        /// <summary>
        /// Get all method.
        /// </summary>
        /// <returns>The list of all players.</returns>
        [HttpGet]
        [ActionName("all")]
        public IEnumerable<Models.Player> GetAll()
        {
            var players = this.logic1.GetAllPlayers();
            return this.mapper.Map<IList<Data.Player>, List<Models.Player>>(players);
        }

        /// <summary>
        /// Del one player method.
        /// </summary>
        /// <param name="id">Id of the player to be deleted.</param>
        /// <returns>ApiResult.</returns>
        [HttpGet]
        [ActionName("del")]
        public ApiResult DelOneCar(int id)
        {
            int before = this.logic1.GetAllPlayers().Count;
            this.logic1.RemovePlayer(this.logic1.GetOnePlayer(id));
            int after = this.logic1.GetAllPlayers().Count;

            return new ApiResult() { OperationResult = before != after };
        }

        /// <summary>
        /// Add one pLayer method.
        /// </summary>
        /// <param name="player">Player to be added.</param>
        /// <returns>ApiResult.</returns>
        [HttpPost]
        [ActionName("add")]
        public ApiResult AddOnePlayer(Models.Player player)
        {
            int id = 0;
            foreach (var p in this.logic1.GetAllPlayers())
            {
                if (p.PlayerId == player.PlayerId)
                {
                    id++;
                    player.PlayerId = id;
                }
            }

            bool success = true;
            try
            {
                this.logic1.InsertPlayer(new Data.Player() { PlayerId = player.PlayerId, PlayerAge = player.PlayerAge, PlayerFieldGoal = player.PlayerFieldGoal, PlayerHeight = player.PlayerHeight, PlayerName = player.PlayerName, PlayerPosition = player.PlayerPosition, PlayerSalary = player.PlayerSalary, PlayerWeight = player.PlayerWeight, PlayerDraftDate = player.PlayerDraftDate });
            }
            catch (ArgumentException)
            {
                success = false;
            }

            return new ApiResult() { OperationResult = success };
        }

        /// <summary>
        /// ModOnePlayer Method.
        /// </summary>
        /// <param name="player">Player to be modified.</param>
        /// <returns>ApiResult.</returns>
        [HttpPost]
        [ActionName("mod")]
        public ApiResult ModOnePlayer(Models.Player player)
        {
            Data.Player neww = new Data.Player()
            {
                PlayerId = player.PlayerId,
                PlayerAge = player.PlayerAge,
                PlayerDraftDate = player.PlayerDraftDate,
                PlayerFieldGoal = player.PlayerFieldGoal,
                PlayerHeight = player.PlayerHeight,
                PlayerName = player.PlayerName,
                PlayerPosition = player.PlayerPosition,
                PlayerSalary = player.PlayerSalary,
                PlayerWeight = player.PlayerWeight,
            };
            this.logic2.FullPlayerUpdateLogic(player.PlayerId, neww);
            return new ApiResult() { OperationResult = true };
        }
    }
}
