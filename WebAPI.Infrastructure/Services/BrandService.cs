//-------------------------------------------------------------------------------
// <copyright file="BrandService.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Models;
    using WebAPI.Core.Repositories;
    using WebAPI.Core.Services;

    /// <summary>Brand service class</summary>
    public class BrandService : IBrandService
    {
        #region Fields

        /// <summary>The service provider</summary>
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
        public async Task<IEnumerable<Brand>> GetBrands()
        {
            var brandsService = this.serviceProvider.GetRequiredService<IBrandRepository>();
            var brands = await brandsService.GetBrands();

            return brands;
        }

        #endregion
    }
}
