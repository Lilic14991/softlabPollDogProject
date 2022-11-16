﻿//-------------------------------------------------------------------------------
// <copyright file="BrandController.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
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

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public BrandController(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        #endregion

        #region GetMethods

        /// <summary>Gets the brands.</summary>
        /// <returns>The list of brands. </returns>
        public async override Task<IActionResult> GetBrands()
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

        #endregion

    }
}
