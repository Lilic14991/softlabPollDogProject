//-------------------------------------------------------------------------------
// <copyright file="BrandControllerBase.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Dtos;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary> BaseController for Brand </summary>
    [Route("api/brand")]
    [ApiController]
    public abstract class BrandControllerBase : ControllerBase
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandControllerBase" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public BrandControllerBase(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the brands.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerOperation(OperationId = "GetBrands", Summary = "Gets the list of brands.")]
        [SwaggerResponse(statusCode: 200, description: "Success",type: typeof(List<Brand>))]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> GetBrands();

        #endregion
    }
}
