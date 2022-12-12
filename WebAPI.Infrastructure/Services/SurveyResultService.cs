// -------------------------------------------------------------------------------
// <copyright file="SurveyResultService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Services
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Repositories;
    using WebAPI.Core.Services;
    using Models = WebAPI.Core.Models;

    /// <summary>
    /// SurveyResultService class.
    /// </summary>
    public class SurveyResultService : ISurveyResultService
    {
        #region Fields

        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SurveyResultService" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        #endregion

        #region Public methods

        /// <summary>Creates the specified survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>Return task.</returns>
        public async Task Create(Models.SurveyResult surveyResult)
        {
            // resolve services
            var surveyResultRepository = this.serviceProvider.GetRequiredService<ISurveyResultRepository>();

            await surveyResultRepository.Create(
                surveyResult.Products
                .Select(x => x.Id).FirstOrDefault(),
                surveyResult.Stars,
                surveyResult.Comment);
        }

        /// <summary>Gets the product with average rating.</summary>
        /// <returns>The list of products with average rating.</returns>
        public async Task<IEnumerable<Models.Product>> GetProductWithAverageRating()
        {
            // resolve services
            var surveyResultRepository = this.serviceProvider.GetRequiredService<ISurveyResultRepository>();

            var productsWithAverageRating = await surveyResultRepository.GetSurveyResultAverageRating();

            return productsWithAverageRating;
        }

        #endregion
    }
}
