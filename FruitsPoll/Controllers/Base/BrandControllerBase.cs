// -------------------------------------------------------------------------------
// <copyright file="BrandControllerBase.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;
    using DTO = PollDog.API.DTO;

    /// <summary>Controller base class for brand controller.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BrandControllerBase : ControllerBase
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandControllerBase" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public BrandControllerBase(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        #endregion

        #region Public methods

        /// <summary>Gets the brands.</summary>
        /// <returns>
        ///   The list of brands.
        /// </returns>
        [HttpGet]
        [SwaggerOperation(OperationId = "GetBrands", Summary = "Gets the list of brands.")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<DTO.Brand>), description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> GetBrands();

        #endregion
    }
}
