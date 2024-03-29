﻿// -------------------------------------------------------------------------------
// <copyright file="ProductService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Services;
    using Models = WebAPI.Core.Models;
    using Repositories = WebAPI.Core.Repositories;

    /// <summary>Product service class.</summary>
    public class ProductService : IProductService
    {
        #region Fields

        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ProductService" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        #endregion

        #region Public methods

        /// <summary>gets the list of products by BrandId.</summary>
        /// <param name="brandId">Brand Id Guid identifier.</param>
        /// <returns>
        ///     The list of products by BrandId.
        /// </returns>
        public async Task<List<Models.Product>> GetProductsByBrandId(Guid brandId)
        {
            // resolve services
            var productRepository = this.serviceProvider.GetRequiredService<Repositories.IProductRepository>();

            var products = await productRepository.GetProductsByBrandId(brandId);

            return products;
        }

        #endregion
    }
}
