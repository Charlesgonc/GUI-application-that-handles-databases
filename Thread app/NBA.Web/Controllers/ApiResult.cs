// <copyright file="ApiResult.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using NBA.Logic;

    /// <summary>
    /// ApiResult.
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the operation Result prop.
        /// </summary>
        public bool OperationResult { get; set; }
    }
}
