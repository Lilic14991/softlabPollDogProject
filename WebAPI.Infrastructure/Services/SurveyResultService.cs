// -------------------------------------------------------------------------------
// <copyright file="ProductService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Models;
    using WebAPI.Core.Repositories;
    using WebAPI.Core.Services;

    /// <summary>
    /// SurveyResultService class.
    /// </summary>
    /// <seealso cref="WebAPI.Core.Services.ISurveyResultService" />
    public class SurveyResultService : ISurveyResultService
    {
        /// <summary>The service provider</summary>
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
        public Task Create(SurveyResult surveyResult)
        {
            var surveyResultService = this.serviceProvider.GetRequiredService<ISurveyResultRepository>();
            return surveyResultService.Create(surveyResult);
        }
    }
}
