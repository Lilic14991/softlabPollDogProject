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
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Repositories;
    using WebAPI.Core.Services;
    using Models = WebAPI.Core.Models;

    /// <summary>SurveyResult repository class.</summary>
    public class SurveyResultRepository : ISurveyResultRepository
    {
        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>Initializes a new instance of the <see cref="SurveyResultRepository" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultRepository(IServiceProvider serviceProvider)
        {
        }

        /// <summary>Creates the specified survey result.</summary>
        /// <param name="productId">guid parameter for ProductId.</param>
        /// <param name="rating">int parameter for Rating.</param>
        /// <param name="comment">string parameter for Comment.</param>
        /// <returns>Returns task.</returns>
        public async Task Create(Guid productId, int rating, string comment)
        {
            var configService = this.serviceProvider.GetRequiredService<IConfigService>();

            using (var connection = configService.Connection)
            {
                await connection.OpenAsync();

                var parameters = new { productId, rating, comment };

                var sql = @"INSERT INTO [Survey].[SurveyResult] ([ProductId],[Rating],[Comment]) 
                            VALUES (@ProductId, @Rating, @Comment)";

                await connection.ExecuteAsync(sql, parameters);
            }
        }

        /// <summary>Gets the survey result average rating.</summary>
        /// <returns>
        ///   Return list of products with average ratings.
        /// </returns>
        public async Task<IEnumerable<Models.ProductAverageRatings>> GetSurveyResultAverageRating()
        {
            var configService = this.serviceProvider.GetRequiredService<IConfigService>();

            using (var connection = configService.Connection)
            {
                await connection.OpenAsync();

                var view = "SELECT * FROM [Survey].[vSurveyResult]";

                var averageRatings = await connection.QueryAsync<DbModels.ProductAverageRatings>(view);
                var mappedProductAverageRatings = averageRatings.ToList();

                return mappedProductAverageRatings;
            }
        }
    }
}
