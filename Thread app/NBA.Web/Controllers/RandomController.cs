// <copyright file="RandomController.cs" company="PlaceholderCompany">
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
    /// Random Controller.
    /// </summary>
    public class RandomController : Controller
    {
        private static Random rand = new Random();
        private ITeamManagerLogic logic1;
        private INbaSecretaryLogic logic2;

        private IMapper mapper;
        private PlayerListViewModel vm;

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomController"/> class.
        /// </summary>
        /// <param name="logic1">Team manager logic.</param>
        /// <param name="logic2">NBA secretary logic.</param>
        /// <param name="mapper">Mapper.</param>
        public RandomController(ITeamManagerLogic logic1, INbaSecretaryLogic logic2, IMapper mapper)
        {
            this.logic1 = logic1;
            this.logic2 = logic2;
            this.mapper = mapper;

            this.vm = new PlayerListViewModel();
            this.vm.EditedPLayer = new Models.Player();

            var players = logic1.GetAllPlayers();
            this.vm.ListOfPlayers = this.mapper.Map<IList<Data.Player>, List<Models.Player>>(players);
        }

        /// <summary>
        /// Add one pLayer method.
        /// </summary>
        /// <returns>ApiResult.</returns>
        [HttpGet]
        [ActionName("GetOne")]
        public JsonResult GetOnePlayer()
        {
            var player = this.logic1.GetOnePlayer(this.RandomInsertion());
            return this.Json(this.mapper.Map<Data.Player, Models.Player>(player));
        }

        /// <summary>
        /// Action Result for the Details.
        /// </summary>
        /// <returns>IActionResult.</returns>
        public IActionResult Selections()
        {
            return this.View("RandomSelection", this.vm.ListOfPlayers.ToList());
        }

        // Get: Random/Select/5

        /// <summary>
        /// Action Result for the Details.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>IActionResult.</returns>
        public IActionResult Select(int id)
        {
            this.TempData["editResult"] = " Selection failed";

            var player = this.logic1.GetOnePlayer(id);
            if (player != null)
            {
                player.PlayerIsSelected = 1;
                this.logic2.FullPlayerUpdateLogic(id, player);
                this.TempData["editResult"] = " Selection Successful";
            }

            int selected = 0;
            int unselected = 0;
            foreach (var p in this.logic1.GetAllPlayers())
            {
                if (p.PlayerIsSelected == 1)
                {
                    selected++;
                }
                else
                {
                    unselected++;
                }
            }

            this.TempData["counter"] = $"Selected Players: {selected}\nUnselected Players: {unselected}";

            return this.Json(player);
        }

        // Get: Random/Unselect/5

        /// <summary>
        /// Action Result for the Details.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>IActionResult.</returns>
        public IActionResult Unselect(int id)
        {
            this.TempData["editResult"] = " Unselection failed";

            var player = this.logic1.GetOnePlayer(id);
            if (player != null)
            {
                player.PlayerIsSelected = 0;
                this.logic2.FullPlayerUpdateLogic(id, player);
                this.TempData["editResult"] = " Unselection Successful";
            }

            int selected = 0;
            int unselected = 0;
            foreach (var p in this.logic1.GetAllPlayers())
            {
                if (p.PlayerIsSelected == 1)
                {
                    selected++;
                }
                else
                {
                    unselected++;
                }
            }

            this.TempData["counter"] = $"Selected Players: {selected}\nUnselected Players: {unselected}";

            return this.Json(player);
        }

        /// <summary>
        /// Del one player method.
        /// </summary>
        /// <param name="id">Id of the player to be deleted.</param>
        [HttpGet]
        [ActionName("del")]
        public void DelOneCar(int id)
        {
            int before = this.logic1.GetAllPlayers().Count;
            this.logic1.RemovePlayer(this.logic1.GetOnePlayer(id));
            int after = this.logic1.GetAllPlayers().Count;

            if (before == after)
            {
                this.TempData["editResult"] = " Deletion failed";
            }

            this.TempData["editResult"] = " Deletion succeeded";

            // return new ApiResult() { OperationResult = before != after };
        }

        // -------------------------------------------HELPER METHODS------------------------------------------------------------------
        private int RandomInsertion()
        {
            int id = 1;
            foreach (var p in this.logic1.GetAllPlayers())
            {
                if (p.PlayerId == id)
                {
                    id++;
                }
            }

            // bool success = true;
            try
            {
                this.logic1.InsertPlayer(new Data.Player() { PlayerId = id, PlayerAge = rand.Next(18, 38), PlayerFieldGoal = rand.Next(0, 101), PlayerHeight = rand.Next(160, 230), PlayerName = this.NameHelper(), PlayerPosition = this.NameHelper(), PlayerSalary = rand.Next(0, 1000000), PlayerWeight = rand.Next(100, 200), PlayerDraftDate = DateTime.Now, PlayerIsSelected = (byte)rand.Next(0, 2) });
            }
            catch (ArgumentException)
            {
                // success = false;
            }

            return id;

            // return new ApiResult() { OperationResult = success };
        }

        private string NameHelper()
        {
            char[] letters = { 'a', 'b', 'c', 'x', 'y', 'z', '1', '2', '3' };
            string name = string.Empty;
            for (int i = 0; i < 6; i++)
            {
                name += letters[rand.Next(0, letters.Length)];
            }

            return name;
        }
    }
}
