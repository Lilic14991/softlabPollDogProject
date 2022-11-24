// -------------------------------------------------------------------------------
// <copyright file="ProductRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Dapper;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Models;
    using WebAPI.Core.Repositories;
    using WebAPI.Infrastructure.Mapper;
    using DbModels = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>Product repository class.</summary>
    public class ProductRepository : IProductRepository
    {
        #region Private fields

        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>The connection string.</summary>
        private readonly string connectionString;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ProductRepository" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductRepository(IServiceProvider serviceProvider)
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

        public async Task Create(Guid brandId, string name)
        {
            using var connection = this.Connection;
            await connection.OpenAsync();

            var parameters = new { brandId, name };

            var sql = @"INSERT INTO [Portfolio].[Product]
            ([Name], [BrandId])
            VALUES(@Name, @BrandId)";

            await connection.ExecuteAsync(sql, parameters);
        }

        #endregion

        #region Public methods

        /// <summary>Gets the products.</summary>
        /// <returns>List of products.<br /></returns>
        public async Task<IEnumerable<Models.Product>> GetProducts()
        {
            using var connection = this.Connection;
            await connection.OpenAsync();

            var query = "SELECT * FROM [Portfolio].[Product]";

            var products = await connection.QueryAsync<DbModels.Product>(query);
            var mappedProducts = new List<Models.Product>();

            foreach (var product in products)
            {
                var modelProduct = product.DatabaseProductToModelProduct();
                mappedProducts.Add(modelProduct);
            }

            return mappedProducts;
        }

        #endregion
    }
}
