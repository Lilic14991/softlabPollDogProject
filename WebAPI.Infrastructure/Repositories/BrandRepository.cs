// -------------------------------------------------------------------------------
// <copyright file="BrandRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Repositories
{
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

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandRepository" /> class.</summary>
        /// <param name="serviceProvider">The context.</param>
        public BrandRepository(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        #endregion

        #region Public methods

        /// <summary>Gets the brands.</summary>
        /// <returns>
        ///     The list of brands.
        /// </returns>
        public async Task<IEnumerable<Models.Brand>> GetBrands()
        {
            // resolve services
            var configService = this.serviceProvider.GetRequiredService<IConfigService>();

            using (var connection = configService.Connection)
            {
                await connection.OpenAsync();

                var query = "SELECT * FROM [Portfolio].[Brand]";

                var brands = await connection.QueryAsync<DbModels.Brand>(query);
                var mappedBrands = brands.Select(b => b.DatabaseBrandToModelBrand()).ToList();

                return mappedBrands;
            }
        }

        /// <summary>Creates the specified name.</summary>
        /// <param name="name">The name.</param>
        /// <returns>
        ///     Returns task.
        /// </returns>
        public async Task Create(string name)
        {
            // resolve services
            var configService = this.serviceProvider.GetRequiredService<IConfigService>();

            using (var connection = configService.Connection)
            {
                await connection.OpenAsync();

                var parameters = new { name };

                var sql = @"INSERT INTO [Portfolio].[Brand] ([Name]) 
                            VALUES(@Name)";

                await connection.QueryAsync(sql, parameters);
            }
        }

        #endregion
    }
}
