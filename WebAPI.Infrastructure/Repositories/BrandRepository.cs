﻿// -------------------------------------------------------------------------------
// <copyright file="BrandRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Repositories
{
    using System.Data;
    using System.Linq;
    using Dapper;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Repositories;
    using WebAPI.Core.Services;
    using WebAPI.Infrastructure.Mapper;
    using DbModels = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>Brand Repository.</summary>
    public class BrandRepository : IBrandRepository
    {
        #region Fields

        /// <summary>The context.</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>The configuration service.</summary>
        private readonly IConfigService configService;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandRepository" /> class.</summary>
        /// <param name="serviceProvider">The context.</param>
        public BrandRepository(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.configService = this.serviceProvider.GetRequiredService<IConfigService>();
        }

        #endregion

        #region Public methods

        /// <summary>Gets the brands.</summary>
        /// <returns>
        ///     The list of brands.
        /// </returns>
        public async Task<List<Models.Brand>> GetBrands()
        {
            using (var connection = this.configService.Connection)
            {
                await connection.OpenAsync();

                var query = "[Portfolio].[Brand.GetBrands]";

                var brands = await connection.QueryAsync<DbModels.Brand>(
                    sql: query,
                    commandType: CommandType.StoredProcedure);
                var mappedBrands = brands.Select(b => b.DatabaseBrandToModelBrand()).ToList();

                return mappedBrands;
            }
        }

        #endregion
    }
}
