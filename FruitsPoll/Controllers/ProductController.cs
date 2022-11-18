// -------------------------------------------------------------------------------
// <copyright file="ProductController.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Controllers.Base;
    using WebAPI.Core.Services;

    /// <summary>Product controller.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ProductControllerBase
    {
        #region Constructor

        /// <summary>Initializes a new instance of the <see cref="ProductController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        #endregion

        #region Public methods

        /// <summary>Gets the products.</summary>
        /// <returns>status code 200 Ok.<br /></returns>
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

        #endregion
    }
}
