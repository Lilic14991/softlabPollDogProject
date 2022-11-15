﻿
namespace PollDog.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Contracts;
    using PollDog.API.Controllers.Base;

    /// <summary>
    ///   <para>Brand Controller</para>
    /// </summary>
    public class BrandController : BrandControllerBase
    {
        /// <summary>The brand repo</summary>
        private readonly IServiceProvider serviceProvider;


        /// <summary>Initializes a new instance of the <see cref="BrandController" /> class.</summary>
        /// <param name="brandRepo">The brand repo.</param>
        public BrandController(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        /// <summary>Gets the brands.</summary>
        /// <returns>The list of brands. </returns>
        public override async Task<IActionResult> GetBrands()
        {
            try
            {
                var brandsService = this.serviceProvider.GetRequiredService<IBrandRepository>();
                var brands = await brandsService.GetBrands();
               
                if (brands == null)
                {
                    return NotFound(brands);
                }
                
                return Ok(brands);
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }
    }
}