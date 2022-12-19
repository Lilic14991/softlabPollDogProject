// -------------------------------------------------------------------------------
// <copyright file="BrandController.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.DependencyInjection;
    using PollDog.API.Controllers.Base;
    using DTO = PollDog.API.DTO;
    using Mapper = AutoMapper;
    using Models = WebAPI.Core.Models;
    using Services = WebAPI.Core.Services;

    /// <summary>
    ///   <para>Brand Controller.</para>
    /// </summary>
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

        #region Public methods

        /// <summary>Gets the brands.</summary>
        /// <returns>
        ///     Returns 200 status code with list of brands.
        /// </returns>
        public async override Task<IActionResult> GetBrands()
        {
            try
            {
                // resolve services
                var brandService = this.ServiceProvider.GetRequiredService<Services.IBrandService>();
                var mapper = this.ServiceProvider.GetRequiredService<Mapper.IMapper>();

                var brands = await brandService.GetBrands();

                if (brands == null)
                {
                    return this.NotFound();
                }

                var mappedResult = mapper.Map<List<Models.Brand>, List<DTO.Brand>>(brands.ToList());

                return this.Ok(mappedResult);
            }
            catch (SqlException sex)
            {
                return this.InternalServerError(sex);
            }
            catch (Exception ex)
            {
                return this.InternalServerError(ex);
            }
        }

        #endregion
    }
}
