// <copyright file="EditorWindow.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.UI
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
    using System.Windows.Shapes;
    using NBA.WPF.Data;
    using NBA.WPF.VM;

    /// <summary>
    /// Interaction logic for EditorWindow.xaml.
    /// </summary>
    public partial class EditorWindow : Window
    {
        /// <summary>
        /// The view model of the editor window.
        /// </summary>
        private EditorViewModel VM;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorWindow"/> class.
        /// </summary>
        public EditorWindow()
        {
            this.InitializeComponent();
            this.VM = this.FindResource("VM") as EditorViewModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorWindow"/> class.
        /// </summary>
        /// <param name="oldPlayerNBA">The player parameter.</param>
        public EditorWindow(PlayerNBA oldPlayerNBA)
            : this()
        {
            this.VM.Player = oldPlayerNBA;
        }

        /// <summary>
        /// Gets the View model player.
        /// </summary>
        public PlayerNBA Player { get => this.VM.Player; }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
