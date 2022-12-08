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

        /// <summary>Internals the server error.</summary>
        /// <param name="ex">The exception.</param>
        /// <returns>
        ///     Returns task.
        /// </returns>
        protected IActionResult InternalServerError(Exception? ex = null)
        {
            return this.StatusCode(500, ex.Message ?? "INTERNAL_SERVER_ERROR");
        }

        /// <summary>Bads the request.</summary>
        /// <param name="ex">The exception.</param>
        /// <returns>
        ///     Returns task.
        /// </returns>
        protected IActionResult BadRequest(Exception? ex = null)
        {
            return this.StatusCode(400, ex.Message ?? "BAD_REQUEST");
        }

    }
}
