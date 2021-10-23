// <copyright file="MainWindow.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace NBA.WPF
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
    using GalaSoft.MvvmLight.Messaging;
    using NBA.WPF.VM;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel VM;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.VM = this.FindResource("VM") as MainViewModel;
            Messenger.Default.Register<string>(this, "LogicResult", (msg) => { MessageBox.Show(msg); });
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // unsubscribing the messenger event
            Messenger.Default.Unregister(this);
        }
    }
}
