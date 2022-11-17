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
        protected readonly IServiceProvider ServiceProvider;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ControllerBase" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ControllerBase(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        #endregion
    }
}
