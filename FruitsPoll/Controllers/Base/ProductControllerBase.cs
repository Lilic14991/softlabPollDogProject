﻿// -------------------------------------------------------------------------------
// <copyright file="ProductControllerBase.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;
    using DTO = PollDog.API.DTO;

    /// <summary>Product controller base abstract class.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ProductControllerBase : ControllerBase
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ProductControllerBase" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductControllerBase(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        #endregion

        #region Public methods

        /// <summary>Gets the list of products by BrandId.</summary>
        /// <param name="brandId">Brand Id Guid identifier.</param>
        /// <returns>
        ///     The list of products by BrandId.
        /// </returns>
        [HttpGet("{brandId}")]
        [SwaggerOperation(OperationId = "GetProductsByBrandId", Summary = "Gets list of products by Brand identifier")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<DTO.ProductResponse>), description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> GetProductsByBrandId([FromRoute] Guid brandId);

        #endregion
    }
}
