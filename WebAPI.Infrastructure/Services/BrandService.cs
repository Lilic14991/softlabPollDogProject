// -------------------------------------------------------------------------------
// <copyright file="BrandService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Repositories;
    using WebAPI.Core.Services;
    using Models = WebAPI.Core.Models;

    /// <summary>Brand service class.</summary>
    public class BrandService : IBrandService
    {
        #region Private fields

        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandService" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public BrandService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        #endregion

        #region Public methods

        /// <summary>Gets the brands.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<IEnumerable<Models.Brand>> GetBrands()
        {
            var brandsService = this.serviceProvider.GetRequiredService<IBrandRepository>();
            var brands = await brandsService.GetBrands();

            return brands;
        }

        /// <summary>Creates the specified brand.</summary>
        /// <param name="brand">The brand.</param>
        public async Task Create(Models.Brand brand)
        {
            var brandService = this.serviceProvider.GetRequiredService<IBrandRepository>();
            await brandService.Create(brand.Name);
        }

        #endregion
    }
}
