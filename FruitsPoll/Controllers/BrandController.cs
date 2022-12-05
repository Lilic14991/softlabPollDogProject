// -------------------------------------------------------------------------------
// <copyright file="BrandController.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers
{
    using global::AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Controllers.Base;
    using WebAPI.Core.Services;
    using DTO = PollDog.API.DTO;
    using Models = WebAPI.Core.Models;

    /// <summary>
    ///   <para>Brand Controller.</para>
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BrandControllerBase
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// resolve services
        public BrandController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>Gets the brands.</summary>
        /// <returns>Returns the list of brands. </returns>
        public async override Task<IActionResult> GetBrands()
        {
            try
            {
                // resolve services
                var brandsService = this.ServiceProvider.GetRequiredService<IBrandService>();
                var brands = await brandsService.GetBrands();

                if (brands == null)
                {
                    return this.NotFound(brands);
                }

                return this.Ok(brands);
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }

        /// <summary>Creates the specified brand.</summary>
        /// <param name="brand">The brand.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        public override async Task<IActionResult> Create([FromBody] DTO.CreateBrand brand)
        {
            try
            {
                // resolve services
                var brandService = this.ServiceProvider.GetRequiredService<IBrandService>();

                // resolve services
                var mapper = this.ServiceProvider.GetRequiredService<IMapper>();
                var mappedResult = mapper.Map<DTO.CreateBrand, Models.Brand>(brand);
                await brandService.Create(mappedResult);

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
