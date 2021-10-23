// <copyright file="EditorServiceViaWindow.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.WPF.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NBA.WPF.BL;
    using NBA.WPF.Data;

    /// <summary>
    /// The editor window via Window.
    /// </summary>
    public class EditorServiceViaWindow : IEditorService
    {
        /// <summary>
        /// Window's feedback about the edit status.
        /// </summary>
        /// <param name="player">Player to be edited.</param>
        /// <returns>The bool feedback regarding the edit of the player.</returns>
        public bool EditPlayer(PlayerNBA player)
        {
            EditorWindow window = new EditorWindow(player);
            return window.ShowDialog() ?? false;
        }
    }
}
