// -------------------------------------------------------------------------------
// <copyright file="SurveyResultMapper.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Mapper
{
    using System.Linq;
    using DbModels = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>SurveyResult mapper static class.</summary>
    public static class SurveyResultMapper
    {
        #region Extension Methods

        /// <summary>Databases the survey result to model survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>
        ///   The new instance of SurveyResult model.
        /// </returns>
        public static Models.SurveyResult DatabaseSurveyResultToModelSurveyResult(this DbModels.SurveyResult surveyResult)
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
        ///   The new instance of ProductAverageRating model.
        /// </returns>
        public static Models.ProductAverageRating DatabaseProductAverageRatingToModel(this DbModels.ProductAverageRating productAverageRating)
        {
            if (productAverageRating == null)
            {
                return null;
            }

            return new Models.ProductAverageRating
            {
                ProductName = productAverageRating.ProductName,
                BrandName = productAverageRating.BrandName,
                Average = productAverageRating.Average,
            };
        }

        #endregion
    }
}
