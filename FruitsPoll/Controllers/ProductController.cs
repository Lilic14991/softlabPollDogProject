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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ProductControllerBase
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ProductController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        #endregion

        #region Public methods

        /// <summary>Gets the products.</summary>
        /// <returns>Returns task of IActionResult.<br /></returns>
        public async override Task<IActionResult> GetProducts()
        {
            try
            {
                var productsService = this.ServiceProvider.GetRequiredService<IProductService>();

                var products = await productsService.GetProducts();

                if (products == null)
                {
                    return this.NotFound();
                }

                return this.Ok(products);
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }

        /// <summary>Creates the products.</summary>
        /// <param name="product">product object.</param>
        /// <returns>
        ///   Returns task of IActionResult.
        /// </returns>
        public async override Task<IActionResult> Create([FromBody] DTO.CreateProduct product)
        {
            try
            {
                var productService = this.ServiceProvider.GetRequiredService<IProductService>();
                var mapper = this.ServiceProvider.GetRequiredService<IMapper>();
                var mappedResult = mapper.Map<DTO.CreateProduct, Models.Product>(product);
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
