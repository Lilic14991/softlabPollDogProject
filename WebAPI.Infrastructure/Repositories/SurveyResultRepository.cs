// -------------------------------------------------------------------------------
// <copyright file="SurveyResultRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Dapper;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Repositories;
    using Models = WebAPI.Core.Models;

    /// <summary>SurveyResult repository class.</summary>
    public class SurveyResultRepository : ISurveyResultRepository
    {
        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>The connection string.</summary>
        private readonly string connectionString;

        /// <summary>Initializes a new instance of the <see cref="SurveyResultRepository" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultRepository(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            var configuration = this.serviceProvider.GetService<IConfiguration>();
            this.connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

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

        /// <summary>Creates the specified survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>representing the asynchronous operation.</returns>
        public async Task Create(Models.SurveyResult surveyResult)
        {
            using (var connection = this.Connection)
            {
                await connection.OpenAsync();

                var sql = "INSERT INTO [Survey].[SurveyResult] ([ProductId],[Rating],[Comment]) VALUES (@ProductId, @Rating, @Comment)";
                await connection.ExecuteAsync(sql, surveyResult);
            }
        }

        /// <summary>Gets the survey result average rating.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<IEnumerable<Models.ProductAverageRatings>> GetSurveyResultAverageRating()
        {
            using (var connection = this.Connection)
            {
                await connection.OpenAsync();
                var averageRating = connection.QueryAsync<Models.ProductAverageRatings>(
                    "SELECT * FROM [Survey].[vSurveyResult]");
                var mappedProductAverageRating = new List<Models.ProductAverageRatings>();
                return mappedProductAverageRating;
            }
        }
    }
}
