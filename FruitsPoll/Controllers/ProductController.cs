// -------------------------------------------------------------------------------
// <copyright file="ProductController.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers
{
    using global::AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Controllers.Base;
    using WebAPI.Core.Services;
    using Models = WebAPI.Core.Models;

    /// <summary>Product controller.</summary>
    public class ProductController : ProductControllerBase
    {
        #region Fields

        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ProductController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        #endregion

        #region Public methods

        /// <summary>Gets the products.</summary>
        /// <returns>Returns 200 status code.</returns>
        public async override Task<IActionResult> GetProducts([FromRoute] Guid brandId)
        {
            try
            {
                // resolve services
                var productService = this.ServiceProvider.GetRequiredService<IProductService>();
                var mapper = this.ServiceProvider.GetRequiredService<IMapper>();

                var products = await productService.GetProducts(brandId);

                if (products == null)
                {
                    return this.NotFound();
                }
                var mappedResult = mapper.Map<List<Models.Product>, List<DTO.Product>>(products.ToList());

                return this.Ok(mappedResult);
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }

        /// <summary>Creates the products.</summary>
        /// <param name="product">product object.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        public async override Task<IActionResult> Create([FromBody] DTO.ProductCreate product)
        {
            try
            {
                // resolve services
                var productService = this.ServiceProvider.GetRequiredService<IProductService>();

                // resolve services
                var mapper = this.ServiceProvider.GetRequiredService<IMapper>();

                var mappedResult = mapper.Map<DTO.ProductCreate, Models.Product>(product);
                await productService.Create(mappedResult);

                return this.Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }

        #endregion
    }
}
