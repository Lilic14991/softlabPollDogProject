// -------------------------------------------------------------------------------
// <copyright file="BrandRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Repositories
{
    using System.Security.Cryptography.Xml;
    using Dapper;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Repositories;
    using WebAPI.Infrastructure.Mapper;
    using DbModels = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>Brand Repository.</summary>
    public class BrandRepository : IBrandRepository
    {
        #region Fields

        /// <summary>The context.</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>The connection string.</summary>
        private readonly string connectionString;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandRepository" /> class.</summary>
        /// <param name="serviceProvider">The context.</param>
        public BrandRepository(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            var configuration = this.serviceProvider.GetService<IConfiguration>();
            this.connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        #endregion

        #region Public properties

        /// <summary>Gets the connection.</summary>
        /// <value>The connection.</value>
        public SqlConnection Connection
        {
            get
            {
                var connection = new SqlConnection(this.connectionString);
                return connection;
            }
        }

        #endregion

        #region Public methods

        /// <summary>Gets the brands.</summary>
        /// <returns>List of brands.</returns>
        public async Task<IEnumerable<Models.Brand>> GetBrands()
        {
            using var connection = this.Connection;
            await connection.OpenAsync();

            var query = "SELECT * FROM [Portfolio].[Brand]";

            var brands = await connection.QueryAsync<DbModels.Brand>(query);
            var mappedBrands = new List<Models.Brand>();

            foreach (var brand in brands)
            {
                var modelBrand = brand.DatabaseBrandToModelBrand();
                mappedBrands.Add(modelBrand);
            }

            return mappedBrands;
        }

        #endregion
    }
}
