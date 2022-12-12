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
    using WebAPI.Infrastructure.Mapper;
    using Models = WebAPI.Core.Models;

    /// <summary>SurveyResult repository class.</summary>
    public class SurveyResultRepository : ISurveyResultRepository
    {
        #region Fields

        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>The configuration service.</summary>
        private readonly IConfigService configService;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SurveyResultRepository" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultRepository(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.configService = this.serviceProvider.GetRequiredService<IConfigService>();
        }

        #endregion

        #region Public methods

        /// <summary>Creates the specified survey result.</summary>
        /// <param name="productId">guid parameter for ProductId.</param>
        /// <param name="rating">int parameter for Rating.</param>
        /// <param name="comment">string parameter for Comment.</param>
        /// <returns>
        ///     Returns task.
        /// </returns>
        public async Task Create(Guid productId, int rating, string comment)
        {
            using (var connection = this.configService.Connection)
            {
                await connection.OpenAsync();

                var parameters = new
                {
                    ProductId = productId,
                    Rating = rating,
                    Comment = comment,
                };

                var query = @"INSERT INTO [Survey].[SurveyResult] ([ProductId],[Rating],[Comment]) 
                            VALUES (@ProductId, @Rating, @Comment)";

                await connection.ExecuteAsync(query, parameters);
            }
        }

        /// <summary>Gets the survey result average rating.</summary>
        /// <returns>
        ///   The list of products with average rating.
        /// </returns>
        public async Task<IEnumerable<Models.Product>> GetSurveyResultAverageRating()
        {
            using (var connection = this.configService.Connection)
            {
                await connection.OpenAsync();

                var view = "SELECT * FROM [Survey].[vSurveyResult]";

                var averageRating = await connection.QueryAsync<DbModels.ProductAverageRating>(view);
                var mappedProductAverageRatings = averageRating.Select(ar => ar.DatabaseProductAverageRatingToModel());

                return mappedProductAverageRatings;
            }
        }

        #endregion
    }
}
