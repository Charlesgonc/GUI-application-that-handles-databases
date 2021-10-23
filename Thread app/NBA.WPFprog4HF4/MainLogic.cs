// <copyright file="MainLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPFprog4hf
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    /// <summary>
    /// Main logic.
    /// </summary>
    public class MainLogic : IMainLogic
    {
        private string url = "http://localhost:50056/Random/";
        private HttpClient client = new HttpClient();
        private JsonSerializerOptions jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);

        /// <summary>
        /// Execute n times the get one method.
        /// </summary>
        /// <returns>The list of the generated ones.</returns>
        public PlayerVM ExecuteGetOnes()
        {
            string json = this.client.GetStringAsync(this.url + "GetOne").Result;
            var s = JsonSerializer.Deserialize<PlayerVM>(json, this.jsonOptions);

            return s;
        }

        /// <summary>
        /// Select method.
        /// </summary>
        /// <param name="id">id of the playyer to be selected.</param>
        public void SelectLogic(int id)
        {
            var stringContent = new StringContent(id.ToString());
            this.client.PostAsync(this.url + "Select/" + $"{id}", stringContent);
        }

        /// <summary>
        /// Unselect method.
        /// </summary>
        /// <param name="id">id of the playyer to be unselected.</param>
        public void UnselectLogic(int id)
        {
            var stringContent = new StringContent(id.ToString());
            this.client.PostAsync(this.url + "Unselect/" + $"{id}", stringContent);
        }

        /// <summary>
        /// Delete method.
        /// </summary>
        /// <param name="id">Id of the player to be deleted.</param>
        public void DeleteOne(int id)
        {
            this.client.GetStringAsync(this.url + "del/" + $"{id}");
        }
    }
}
