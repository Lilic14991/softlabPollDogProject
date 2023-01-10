// -------------------------------------------------------------------------------
// <copyright file="ControllerBase.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Exceptions;

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
        /// <param name="serviceProvider">
        ///     The service provider.
        /// </param>
        public ControllerBase(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        #endregion

        #region Protected methods

        /// <summary>Internals the server error.</summary>
        /// <param name="ex">The exception.</param>
        /// <returns>
        ///     Returns internal server error or string exception.
        /// </returns>
        protected IActionResult InternalServerError(Exception? ex = null)
        {
            return this.StatusCode(500, ErrorMessages.GetExceptionMessage(ex?.Message) ?? "INTERNAL_SERVER_ERROR");
        }

        /// <summary>Bads the request.</summary>
        /// <param name="ex">The exception.</param>
        /// <returns>
        ///     Returns bad request or string exception.
        /// </returns>
        protected IActionResult BadRequest(Exception? ex = null)
        {
            return this.StatusCode(400, ErrorMessages.GetExceptionMessage(ex?.Message) ?? "BAD_REQUEST");
        }

        #endregion
    }
}
