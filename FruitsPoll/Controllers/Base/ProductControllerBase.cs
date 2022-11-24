// -------------------------------------------------------------------------------
// <copyright file="ProductControllerBase.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Identity.Client;
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

        /// <summary>Gets the products.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpGet]
        [SwaggerOperation(OperationId = "GetProducts", Summary = "gets list of products")]
        [SwaggerResponse(statusCode: 200, description: "Success", type: typeof(List<Product>))]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> GetProducts();

        /// <summary>Creates the products.</summary>
        /// <param name="product"> product object.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [HttpPost]
        [SwaggerOperation(OperationId = "CreateProducts", Summary = "create a product")]
        [SwaggerResponse(statusCode: 200, description: "Success", type: typeof(CreateProduct))]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> Create(DTO.CreateProduct product);
        #endregion
    }
}
