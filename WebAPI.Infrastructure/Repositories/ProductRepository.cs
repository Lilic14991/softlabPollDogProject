// -------------------------------------------------------------------------------
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

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ProductRepository" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductRepository(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
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
            // resolve services
            var configService = this.serviceProvider.GetRequiredService<IConfigService>();

            using (var connection = configService.Connection)
            {
                await connection.OpenAsync();

                var parameters = new { brandId, name };

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
            // resolve services
            var configService = this.serviceProvider.GetRequiredService<IConfigService>();

            using (var connection = configService.Connection)
            {
                await connection.OpenAsync();

                var parameters = new { brandId };

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
