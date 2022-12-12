// -------------------------------------------------------------------------------
// <copyright file="SurveyResultMapper.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Mapper
{
    using DbModels = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>SurveyResult mapper static class.</summary>
    public static class SurveyResultMapper
    {
        #region Extension methods

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
                ProductId = surveyResult.ProductId,
            };
        }

        /// <summary>Databases the product average rating to model.</summary>
        /// <param name="productAverageRating">The product average rating.</param>
        /// <returns>
        ///   The new instance of ProductAverageRating model.
        /// </returns>
        public static Models.Product DatabaseProductAverageRatingToModel(this DbModels.ProductAverageRating productAverageRating)
        {
            if (productAverageRating == null)
            {
                return null;
            }

            return new Models.Product
            {
                BrandName = productAverageRating.BrandName,
                Name = productAverageRating.ProductName,
                Average = Math.Round(productAverageRating.Average, 2, MidpointRounding.AwayFromZero),
            };
        }

        #endregion
    }
}
