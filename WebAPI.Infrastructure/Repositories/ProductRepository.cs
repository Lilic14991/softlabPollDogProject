// -------------------------------------------------------------------------------
// <copyright file="ProductRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data;
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

                var procedure = "[Portfolio].[Product.GetProductsByBrandId]";

                var parameters = new
                {
                    BrandId = brandId,
                };

                var products = await connection.QueryAsync<DbModels.Product>(
                    procedure,
                    parameters,
                    commandType: CommandType.StoredProcedure);
                var mappedProducts = products.Select(p => p.DatabaseProductToModelProduct()).ToList();

                return mappedProducts;
            }
        }

        #endregion
    }
}
