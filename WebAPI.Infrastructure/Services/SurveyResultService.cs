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
    /// <seealso cref="WebAPI.Core.Services.ISurveyResultService" />
    public class SurveyResultService : ISurveyResultService
    {
        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>Initializes a new instance of the <see cref="SurveyResultService" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        /// <summary>Creates the specified survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>Created surveyResult object.</returns>
        public async Task Create(Models.SurveyResult surveyResult)
        {
            var surveyResultService = this.serviceProvider.GetRequiredService<ISurveyResultRepository>();
            await surveyResultService.Create(surveyResult.Products.Select(x => x.Id).FirstOrDefault(), (int)surveyResult.Stars, surveyResult.Comment);
        }

        /// <summary>Gets the product with average rating.</summary>
        /// <returns>representing the asynchronous operation.</returns>
        public async Task<IEnumerable<Models.ProductAverageRatings>> GetProductWithAverageRating()
        {
            var surveyResultService = this.serviceProvider.GetRequiredService<ISurveyResultRepository>();
            var productsWithAverageRating = await surveyResultService.GetSurveyResultAverageRating();

            return productsWithAverageRating;
        }
    }
}
