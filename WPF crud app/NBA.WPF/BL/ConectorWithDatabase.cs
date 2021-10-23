// <copyright file="ConectorWithDatabase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NBA.Data;
    using NBA.Logic;
    using NBA.Repository;

    /// <summary>
    /// The class Responsible to conncet the Wpf app with the database.
    /// </summary>
    public class ConectorWithDatabase
    {
        private NBAdbContext ctx;
        private PlayerRepository playerRepository;
        private CoachRepository coachRepository;
        private TeamRepository teamRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConectorWithDatabase"/> class.
        /// </summary>
        public ConectorWithDatabase()
        {
            this.ctx = new NBAdbContext();

            this.coachRepository = new CoachRepository(this.ctx);
            this.playerRepository = new PlayerRepository(this.ctx);
            this.teamRepository = new TeamRepository(this.ctx);

            this.TeamManagerLogic = new TeamManagerLogic(this.playerRepository, this.coachRepository);
            this.NbaSecretaryLogic = new NbaSecretaryLogic(this.teamRepository, this.playerRepository);
            this.FinancialOfficerLogic = new FinancialOfficerLogic(this.playerRepository, this.coachRepository);
        }

        /// <summary>
        /// Gets the Team manager Logic.
        /// </summary>
        public TeamManagerLogic TeamManagerLogic { get; }

        /// <summary>
        /// Gets the NBA secretary Logic.
        /// </summary>
        public NbaSecretaryLogic NbaSecretaryLogic { get; }

        /// <summary>
        /// Gets the Financial Officer Logic.
        /// </summary>
        public FinancialOfficerLogic FinancialOfficerLogic { get; }
    }
}
