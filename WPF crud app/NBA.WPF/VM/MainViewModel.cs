// <copyright file="MainViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.VM
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using CommonServiceLocator;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using NBA.WPF.BL;
    using NBA.WPF.Data;

    /// <summary>
    /// The main window for the selected player.
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// The inteface that gives access to the CRUD operations.
        /// </summary>
        private IPlayerNBALogic logic;

        private PlayerNBA selectedPlayer;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="logic"> The logic that containf the crud operarions. </param>
        public MainViewModel(IPlayerNBALogic logic)
        {
            this.logic = logic;

            this.AllPLayers = new ObservableCollection<PlayerNBA>();

            if (this.IsInDesignMode)
            {
                PlayerNBA p1 = new PlayerNBA()
                {
                    PlayerName = "Charles",
                    PlayerAge = 20,
                    PlayerDraftDate = DateTime.Now,
                    PlayerFieldGoal = 60.0,
                    PlayerHeight = 1.80,
                    PlayerId = 1,
                    PlayerPosition = Positon.PG,
                    PlayerSalary = 60000,
                    PlayerWeight = 70.5,
                    PlayerStatus = Status.Active,
                };

                PlayerNBA p2 = new PlayerNBA()
                {
                    PlayerName = "Goncalves",
                    PlayerAge = 30,
                    PlayerDraftDate = DateTime.Now,
                    PlayerFieldGoal = 70.0,
                    PlayerHeight = 1.70,
                    PlayerId = 1,
                    PlayerPosition = Positon.PG,
                    PlayerSalary = 80000,
                    PlayerWeight = 60.5,
                    PlayerStatus = Status.Unactive,
                };

                this.AllPLayers.Add(p1);
                this.AllPLayers.Add(p2);
            }
            else
            {
                IList<PlayerNBA> players = this.logic.GetAllPlayersNBA();
                foreach (var item in players)
                {
                    this.AllPLayers.Add(item);
                }
            }

            this.AddPlayerCMD = new RelayCommand(() => this.logic.AddPlayerNBA(this.AllPLayers));

            this.EditPlayerCMD = new RelayCommand(() => this.logic.EditPlayerNBA(this.selectedPlayer));

            this.DeletePlayerCMD = new RelayCommand(() => this.logic.DeletePlayerNBA(this.AllPLayers, this.selectedPlayer));
        }

        // IoC

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
            : this(IsInDesignModeStatic ? null : ServiceLocator.Current.GetInstance<IPlayerNBALogic>())
        {
        }

        /// <summary>
        /// Gets or sets the current selected player.
        /// </summary>
        public PlayerNBA SelectedPlayer { get => this.selectedPlayer; set => this.Set(ref this.selectedPlayer, value); }

        /// <summary>
        /// Gets all the players.
        /// </summary>
        public ObservableCollection<PlayerNBA> AllPLayers { get; private set; }

        /// <summary>
        /// Gets the add comand for the player.
        /// </summary>
        public ICommand AddPlayerCMD { get; private set; }

        /// <summary>
        /// Gets the edit command for the player.
        /// </summary>
        public ICommand EditPlayerCMD { get; private set; }

        /// <summary>
        /// Gets the delete command for the player.
        /// </summary>
        public ICommand DeletePlayerCMD { get; private set; }
    }
}
