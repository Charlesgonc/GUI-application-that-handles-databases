// <copyright file="MainVM.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPFprog4hf
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

    /// <summary>
    /// the main VM.
    /// </summary>
    public class MainVM : ViewModelBase
    {
        private IMainLogic logic;
        private int customNumber;
        private ObservableCollection<PlayerVM> randomPlayers;

        /// <summary>
        /// Gets or sets the selected player.
        /// </summary>
        public int CustomNumber
        {
            get { return this.customNumber; }
            set { this.Set(ref this.customNumber, value); }
        }

        /// <summary>
        /// Gets or sets all players.
        /// </summary>
        public ObservableCollection<PlayerVM> RandomPlayers
        {
            get { return this.randomPlayers; }
            set { this.Set(ref this.randomPlayers, value); }
        }

        /// <summary>
        /// Gets the del command.
        /// </summary>
        public ICommand SendCmd { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainVM"/> class.
        /// </summary>
        /// <param name="logic">MainLogic.</param>
        public MainVM(IMainLogic logic)
        {
            this.logic = logic;
            this.RandomPlayers = new ObservableCollection<PlayerVM>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainVM"/> class.
        /// </summary>
        public MainVM()
            : this(IsInDesignModeStatic ? null : ServiceLocator.Current.GetInstance<IMainLogic>())
        {
        }

        private static int count;

        /// <summary>
        /// Helper method.
        /// </summary>
        /// <param name="sender">name.</param>
        /// <param name="e">sender.</param>
        public void Helper(object sender, EventArgs e)
        {
            if (count < this.CustomNumber)
            {
                PlayerVM player = this.logic.ExecuteGetOnes();
                this.RandomPlayers.Add(player);
                count++;
            }
        }

        /// <summary>
        /// Select method.
        /// </summary>
        /// <param name="id">id of the player to be selected.</param>
        public void SelectVM(int id)
        {
            this.logic.SelectLogic(id);
        }

        /// <summary>
        /// Unselect method.
        /// </summary>
        /// <param name="id">id of the player to be unselected.</param>
        public void UnselectVM(int id)
        {
            this.logic.UnselectLogic(id);
        }

        /// <summary>
        /// Delete method.
        /// </summary>
        /// <param name="id">id of the player to be deleted.</param>
        public void DeleteOneVM(int id)
        {
            this.logic.DeleteOne(id);
        }
    }
}
