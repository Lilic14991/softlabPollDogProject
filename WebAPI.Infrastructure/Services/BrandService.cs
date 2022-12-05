// -------------------------------------------------------------------------------
// <copyright file="BrandService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
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
        ///   Return list of brands.
        /// </returns>
        public async Task<IEnumerable<Models.Brand>> GetBrands()
        {
            // resolve services
            var brandRepository = this.serviceProvider.GetRequiredService<IBrandRepository>();
            var brands = await brandRepository.GetBrands();

            return brands;
        }

        /// <summary>Creates the specified brand.</summary>
        /// <param name="brand">The brand.</param>
        /// <returns>Return Task.</returns>
        public async Task Create(Models.Brand brand)
        {
            // resolve services
            var brandRepository = this.serviceProvider.GetRequiredService<IBrandRepository>();
            await brandRepository.Create(brand.Name);
        }

        #endregion
    }
}
