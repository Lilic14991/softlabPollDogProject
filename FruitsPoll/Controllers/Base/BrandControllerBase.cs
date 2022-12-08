// -------------------------------------------------------------------------------
// <copyright file="BrandControllerBase.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.DTO;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>Controlelr base class for brand controller.</summary>
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

        #region Public Methods

        /// <summary>Gets the brands.</summary>
        /// <returns>
        ///   The list of brands.
        /// </returns>
        [HttpGet]
        [SwaggerOperation(OperationId = "GetBrands", Summary = "Gets the list of brands.")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Brand>), description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> GetBrands();

        /// <summary>Creates the specified brand.</summary>
        /// <param name="brand">The brand.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        [HttpPost]
        [SwaggerOperation(OperationId = "Create", Summary = "Create a brand.")]
        [SwaggerResponse(statusCode: 200, type: typeof(BrandCreate), description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> Create(BrandCreate brand);

        #endregion
    }
}
