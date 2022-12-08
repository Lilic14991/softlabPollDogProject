// -------------------------------------------------------------------------------
// <copyright file="ProductControllerBase.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.DTO;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>Base controller for Product.</summary>
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
        /// <returns>The list of products by BrandId.</returns>
        [HttpGet("{brandId}")]
        [SwaggerOperation(OperationId = "GetProductsByBrandId", Summary = "Gets list of products by BrandId")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Product>), description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> GetProductsByBrandId([FromRoute] Guid brandId);

        /// <summary>Creates the products.</summary>
        /// <param name="product"> product object.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        [HttpPost]
        [SwaggerOperation(OperationId = "Create", Summary = "Create a product")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProductCreate), description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> Create(DTO.ProductCreate product);
        #endregion
    }
}
