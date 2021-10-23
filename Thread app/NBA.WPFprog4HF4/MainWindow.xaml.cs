// <copyright file="MainWindow.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPFprog4hf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        private SecondWindow second = new SecondWindow();

        private Random rand = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += (this.DataContext as MainVM).Helper;
            timer.Start();

            DispatcherTimer timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromSeconds(2);
            timer2.Tick += this.SecondWindowDisplay;
            timer2.Start();

            DispatcherTimer timer3 = new DispatcherTimer();
            timer3.Interval = TimeSpan.FromSeconds(2);
            timer3.Tick += this.Switch;
            timer3.Start();
        }

        private void SecondWindowDisplay(object sender, EventArgs e)
        {
            this.second.DataContext = this.DataContext;
            this.second.Show();
        }

        private void Switch(object sender, EventArgs e)
        {
            PlayerVM[] players = new PlayerVM[(this.DataContext as MainVM).RandomPlayers.Count];
            int count = 0;
            foreach (var p in (this.DataContext as MainVM).RandomPlayers)
            {
                players[count] = p;
                count++;
            }

            PlayerVM player = players[this.rand.Next(0, players.Length)];
            if (player.PlayerIsSelected == 0)
            {
                (this.DataContext as MainVM).SelectVM(player.PlayerId);
                player.PlayerIsSelected = 1;
            }
            else if (player.PlayerIsSelected == 1)
            {
                (this.DataContext as MainVM).UnselectVM(player.PlayerId);
                player.PlayerIsSelected = 0;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (var item in (this.DataContext as MainVM).RandomPlayers)
            {
                (this.DataContext as MainVM).DeleteOneVM(item.PlayerId);
            }

            this.second.Close();
        }
    }
}
