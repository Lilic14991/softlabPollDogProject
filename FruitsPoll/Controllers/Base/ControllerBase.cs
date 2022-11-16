//-------------------------------------------------------------------------------
// <copyright file="ControllerBase.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary> The Base Controller</summary>
    public class ControllerBase : Controller
    {
        #region Fields

        /// <summary>The service provider</summary>
        protected IServiceProvider serviceProvider;

        #endregion
    }
}
