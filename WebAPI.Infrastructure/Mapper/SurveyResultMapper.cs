// -------------------------------------------------------------------------------
// <copyright file="SurveyResultMapper.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Mapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WebAPI.Core.Models;
    using Entities = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>SurveyResult mapper static class.</summary>
    public static class SurveyResultMapper
    {
        /// <summary>Databases the survey result to model survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>
        ///   new object <see cref="Models.SurveyResult"/>.
        /// </returns>
        public static Models.SurveyResult DatabaseSurveyResultToModelSurveyResult(this Entities.SurveyResult surveyResult)
        {
            if (surveyResult == null)
            {
                return null;
            }

            return new Models.SurveyResult
            {
                Id = surveyResult.Id,
                Stars = surveyResult.Stars,
                Comment = surveyResult.Comment,
                Products = surveyResult.Products
                .Select(p => new Models.Product() { Id = p.Id, Name = p.Name }).ToList(),
            };
        }

        /// <summary>Databases the product average rating to model.</summary>
        /// <param name="productAverageRating">The product average rating.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static Models.ProductAverageRatings DatabaseProductAverageRatingToModel(this Entities.ProductAverageRatings productAverageRating)
        {
            if (productAverageRating == null)
            {
                return null;
            }

            return new Models.ProductAverageRatings
            {
                ProductName = productAverageRating.ProductName,
                BrandName = productAverageRating.BrandName,
                Average = productAverageRating.Average,
            };
        }
    }
}
