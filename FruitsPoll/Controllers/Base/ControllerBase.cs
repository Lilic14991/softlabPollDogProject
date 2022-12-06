// -------------------------------------------------------------------------------
// <copyright file="ControllerBase.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary> The Base Controller.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerBase : Controller
    {
        #region Fields

        /// <summary>The service provider.</summary>
        protected readonly IServiceProvider ServiceProvider;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ControllerBase" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// resolve services
        public ControllerBase(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        #endregion

        #region Public methods

        /// <summary>Bads the request.</summary>
        /// <returns>
        ///   Returns error message.
        /// </returns>
        //public string BadRequest()
        //{
        //    return "BAD_REQUEST";
        //}

        /// <summary>Internals the server error.</summary>
        /// <returns>
        ///   Returns error message.
        /// </returns>
        //public string InternalServerError()
        //{
        //    return "INTERNAL_SERVER_ERROR";
        //}

        #endregion
    }
}
