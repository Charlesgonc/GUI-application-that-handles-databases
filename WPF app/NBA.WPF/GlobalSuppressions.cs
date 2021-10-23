// <copyright file="GlobalSuppressions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<I would have to check for null only if its needed.>", Scope = "member", Target = "~M:NBA.WPF.BL.PlayerNBALogic.DeletePlayerNBA(System.Collections.Generic.IList{NBA.WPF.Data.PlayerNBA},NBA.WPF.Data.PlayerNBA)")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<I would have to check for null only if its needed.>", Scope = "member", Target = "~M:NBA.WPF.BL.PlayerNBALogic.EditPlayerNBA(NBA.WPF.Data.PlayerNBA)")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<I would have to check for null only if its needed.>", Scope = "member", Target = "~M:NBA.WPF.BL.PlayerNBALogic.AddPlayerNBA(System.Collections.Generic.IList{NBA.WPF.Data.PlayerNBA})")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<The property doesnt necessarily have to be marked static.>", Scope = "member", Target = "~P:NBA.WPF.VM.EditorViewModel.Positions")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Not needed.>", Scope = "member", Target = "~M:NBA.WPF.UI.HeightToStringConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)~System.Object")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Not needed.>", Scope = "member", Target = "~M:NBA.WPF.UI.HeightToStringConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)~System.Object")]
[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1407:Arithmetic expressions should declare precedence", Justification = "<Not needed.>", Scope = "member", Target = "~M:NBA.WPF.UI.HeightToStringConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)~System.Object")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Not needed.>", Scope = "member", Target = "~M:NBA.WPF.UI.HeightToStringConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)~System.Object")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "<Not needed.>", Scope = "member", Target = "~M:NBA.WPF.UI.HeightToStringConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)~System.Object")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Not needed.>", Scope = "member", Target = "~P:NBA.WPF.VM.EditorViewModel.Statuses")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1306:Field names should begin with lower-case letter", Justification = "<Not needed.>", Scope = "member", Target = "~F:NBA.WPF.UI.EditorWindow.VM")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1306:Field names should begin with lower-case letter", Justification = "<Not necessarily.>", Scope = "member", Target = "~F:NBA.WPF.MainWindow.VM")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Not necessarily.>", Scope = "member", Target = "~M:NBA.WPF.UI.DateToStringConverter.Convert(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)~System.Object")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Not necessarily.>", Scope = "member", Target = "~M:NBA.WPF.UI.DateToStringConverter.ConvertBack(System.Object,System.Type,System.Object,System.Globalization.CultureInfo)~System.Object")]
[assembly: SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "<Not necessarily.>", Scope = "type", Target = "~T:NBA.WPF.BL.ConectorWithDatabase")]
