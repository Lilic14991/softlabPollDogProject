﻿// -------------------------------------------------------------------------------
// <copyright file="ISurveyResultRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models = WebAPI.Core.Models;

    /// <summary>Interface SurveyResult Repository.</summary>
    public interface ISurveyResultRepository
    {
        /// <summary>Gets the survey result average rating.</summary>
        /// <returns>
        ///   Return list of ProductAverageRatings.
        /// </returns>
        Task<IEnumerable<Models.ProductAverageRatings>> GetSurveyResultAverageRating();

        /// <summary>Creates the specified product identifier.</summary>
        /// <param name="productId">The product identifier.</param>
        /// <param name="rating">The rating.</param>
        /// <param name="comment">The comment.</param>
        /// <returns>
        ///   Return Task.
        /// </returns>
        Task Create(Guid productId, int rating, string comment);
    }
}
