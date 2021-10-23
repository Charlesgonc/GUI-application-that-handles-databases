// <copyright file="GlobalSuppressions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1202:Elements should be ordered by access", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.PlayersController.Index~Microsoft.AspNetCore.Mvc.IActionResult")]
[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:Field names should not begin with underscore", Justification = "Irrelevant.", Scope = "member", Target = "~F:NBA.Web.Controllers.HomeController._logger")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "Irrelevant.", Scope = "member", Target = "~F:NBA.Web.Controllers.PlayersApiController.logic1")]
[assembly: SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "Irrelevant.>", Scope = "member", Target = "~M:NBA.Web.Controllers.PlayersApiController.AddOnePlayer(NBA.Web.Models.Player)~NBA.Web.Controllers.PlayersApiController.ApiResult")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.PlayersController.#ctor(NBA.Logic.ITeamManagerLogic,NBA.Logic.INbaSecretaryLogic,AutoMapper.IMapper)")]
[assembly: SuppressMessage("Design", "CA1002:Do not expose generic lists", Justification = "Irrelevant.", Scope = "member", Target = "~P:NBA.Web.Models.PlayerListViewModel.ListOfPlayers")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Irrelevant.", Scope = "member", Target = "~P:NBA.Web.Models.PlayerListViewModel.ListOfPlayers")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.PlayersApiController.AddOnePlayer(NBA.Web.Models.Player)~NBA.Web.Controllers.PlayersApiController.ApiResult")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.PlayersApiController.ModOnePlayer(NBA.Web.Models.Player)~NBA.Web.Controllers.PlayersApiController.ApiResult")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.RandomController.#ctor(NBA.Logic.ITeamManagerLogic,NBA.Logic.INbaSecretaryLogic,AutoMapper.IMapper)")]
[assembly: SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.RandomController.RandomInsertion~System.Int32")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.RandomController.NameHelper~System.String")]
[assembly: SuppressMessage("Security", "CA5394:Do not use insecure randomness", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.RandomController.NameHelper~System.String")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "Irrelevant.", Scope = "type", Target = "~T:NBA.Web.Models.MapperFactory")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "Irrelevant.", Scope = "type", Target = "~T:NBA.Web.Program")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1601:Partial elements should be documented", Justification = "Irrelevant.", Scope = "type", Target = "~T:NBA.Web.Controllers.PlayersApiController")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.PlayersApiController.ModOnePlayer(NBA.Web.Models.Player)~NBA.Web.Controllers.ApiResult")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Irrelevant.", Scope = "member", Target = "~M:NBA.Web.Controllers.PlayersApiController.AddOnePlayer(NBA.Web.Models.Player)~NBA.Web.Controllers.ApiResult")]
