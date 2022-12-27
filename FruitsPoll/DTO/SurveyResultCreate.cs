// -------------------------------------------------------------------------------
// <copyright file="SurveyResultCreate.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.DTO
{
    /// <summary>SurveyResult DTO.</summary>
    public record SurveyResultCreate
    {
        /// <summary>Gets the rating.</summary>
        /// <value>The rating.</value>
        public float? Rating { get; init; }

        /// <summary>Gets the comment.</summary>
        /// <value>The comment.</value>
        public string? Comment { get; init; }

        /// <summary>Gets the product.</summary>
        /// <value>The product.</value>
        public ProductRequest? Product { get; init; }
    }
}
