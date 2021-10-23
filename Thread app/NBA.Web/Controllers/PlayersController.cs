// <copyright file="PlayersController.cs" company="PlaceholderCompany">
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
    using NBA.Web.Models;

    /// <summary>
    /// Player controller.
    /// </summary>
    public class PlayersController : Controller
    {
        // needs the logic (always refer to the interface)
        private ITeamManagerLogic logic1;
        private INbaSecretaryLogic logic2;

        private IMapper mapper;
        private PlayerListViewModel vm;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayersController"/> class.
        /// </summary>
        /// <param name="logic1">Team manager logic.</param>
        /// <param name="logic2">NBA secretary logic.</param>
        /// <param name="mapper">Mapper.</param>
        public PlayersController(ITeamManagerLogic logic1, INbaSecretaryLogic logic2, IMapper mapper)
        {
            this.logic1 = logic1;
            this.logic2 = logic2;
            this.mapper = mapper;

            this.vm = new PlayerListViewModel();
            this.vm.EditedPLayer = new Models.Player();

            var players = logic1.GetAllPlayers();
            this.vm.ListOfPlayers = this.mapper.Map<IList<Data.Player>, List<Models.Player>>(players);
        }

        private Models.Player GetPlayerModel(int id)
        {
            Data.Player onePlayer = this.logic1.GetOnePlayer(id);
            return this.mapper.Map<Data.Player, Models.Player>(onePlayer);
        }

        // Actions.
        // Get: Players

        /// <summary>
        /// Action Result for the index.
        /// </summary>
        /// <returns>IActionResult.</returns>
        public IActionResult Index()
        {
            this.ViewData["editAction"] = "AddNew";
            return this.View("PlayersIndex", this.vm);
        }

        // Get: Players/Details/5

       /// <summary>
       /// Action Result for the Details.
       /// </summary>
       /// <param name="id">ID.</param>
       /// <returns>IActionResult.</returns>
        public IActionResult Details(int id)
        {
            return this.View("PlayersDetails", this.GetPlayerModel(id));
        }

        // Get: Players/Remove/5

        /// <summary>
        /// Action Result for the Remove.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>IActionResult.</returns>
        public IActionResult Remove(int id)
        {
            this.TempData["editResult"] = " Delete FAIL";

            int before = this.logic1.GetAllPlayers().Count;

            this.logic1.RemovePlayer(this.logic1.GetOnePlayer(id));

            int after = this.logic1.GetAllPlayers().Count;

            if (before != after)
            {
                this.TempData["editResult"] = " Delete OK";
            }

            return this.RedirectToAction(nameof(this.Index));
        }

        // Edit action that will display the form
        // Get: Players/Edit/5

        /// <summary>
        /// Action Result for the Edit.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>IActionResult.</returns>
        public IActionResult Edit(int id)
        {
            this.ViewData["editAction"] = "Edit";
            this.vm.EditedPLayer = this.GetPlayerModel(id);
            return this.View("PlayersIndex", this.vm);
        }

        // Post Players/Edit + Recive one player + editAction

        /// <summary>
        /// HttpPost for the Edit ActionResult.
        /// </summary>
        /// <param name="player">Player.</param>
        /// <param name="editAction">Edict Action.</param>
        /// <returns>ActionResult.</returns>
        [HttpPost]
        public IActionResult Edit(Models.Player player, string editAction)
        {
            if (this.ModelState.IsValid && player != null)
            {
                this.TempData["editResult"] = " Edit FAIL";
                if (editAction == "AddNew")
                {
                    try
                    {
                        this.logic1.InsertPlayer(new Data.Player()
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
                        });
                        this.TempData["editResult"] = " Edit OK";
                    }
                    catch (ArgumentException)
                    {
                    }
                }
                else
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
                    this.TempData["editResult"] = " Edit OK";
                }

                return this.RedirectToAction(nameof(this.Index));
            }
            else
            {
                this.ViewData["editAction"] = "Edit";
                this.vm.EditedPLayer = player;
                return this.View("PlayersIndex", this.vm);
            }
        }
    }
}
