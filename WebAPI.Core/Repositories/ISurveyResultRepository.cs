// -------------------------------------------------------------------------------
// <copyright file="ISurveyResultRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models = WebAPI.Core.Models;

    /// <summary>Interface SurveyResult Repository.</summary>
    public interface ISurveyResultRepository
    {
        /// <summary>Creates the specified survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task Create(Models.SurveyResult surveyResult);

        /// <summary>Gets the survey result average rating.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        Task<IEnumerable<Models.ProductAverageRatings>> GetSurveyResultAverageRating();
    }
}
