﻿// -------------------------------------------------------------------------------
// <copyright file="ISurveyResultService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models = WebAPI.Core.Models;

    /// <summary>Interface SurveyResultService.</summary>
    public interface ISurveyResultService
    {
        /// <summary>Creates the specified survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        Task Create(Models.SurveyResult surveyResult);

        /// <summary>Gets the product with average rating.</summary>
        /// <returns>
        ///   Returns list of ProductAverageRating.
        /// </returns>
        Task<IEnumerable<Models.Product>> GetProductWithAverageRating();
    }
}
