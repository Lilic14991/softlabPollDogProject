﻿// -------------------------------------------------------------------------------
// <copyright file="ProductRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Dapper;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Repositories;
    using WebAPI.Core.Services;
    using WebAPI.Infrastructure.Mapper;
    using DbModels = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>Product repository class.</summary>
    public class ProductRepository : IProductRepository
    {
        #region Fields

        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>The configuration service.</summary>
        private readonly IConfigService configService;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ProductRepository" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductRepository(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.configService = this.serviceProvider.GetRequiredService<IConfigService>();
        }

        #endregion

        #region Public methods

        /// <summary>Creates the product.</summary>
        /// <param name="brandId">Brand Id Guid parameter.</param>
        /// <param name="name">string parameter for name of product.</param>
        /// <returns>
        ///     Returns task.
        /// </returns>
        public async Task Create(Guid brandId, string name)
        {
            using (var connection = this.configService.Connection)
            {
                await connection.OpenAsync();

                var parameters = new
                {
                    Name = name,
                    BrandId = brandId,
                };

                var query = @"INSERT INTO [Portfolio].[Product] ([Name], [BrandId])
                            VALUES(@Name, @BrandId)";

                await connection.ExecuteAsync(query, parameters);
            }
        }

        /// <summary>Gets the products.</summary>
        /// <param name="brandId">Brand Id Guid identifier.</param>
        /// <returns>
        ///     The list of products by brandId.
        /// </returns>
        public async Task<List<Models.Product>> GetProductsByBrandId(Guid brandId)
        {
            using (var connection = this.configService.Connection)
            {
                await connection.OpenAsync();

                var parameters = new
                {
                    BrandId = brandId,
                };

                var query = @"SELECT * FROM [Portfolio].[Product]
                              WHERE [BrandId] = @BrandId";

                var products = await connection.QueryAsync<DbModels.Product>(query, parameters);
                var mappedProducts = products.Select(p => p.DatabaseProductToModelProduct()).ToList();

                return mappedProducts;
            }
        }

        #endregion
    }
}
