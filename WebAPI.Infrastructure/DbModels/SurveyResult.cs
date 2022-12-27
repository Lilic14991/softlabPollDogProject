// -------------------------------------------------------------------------------
// <copyright file="SurveyResult.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.DbModels
{
    using System;

    /// <summary>class SurveyResult.</summary>
    public record SurveyResult
    {
        /// <summary>Gets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid Id { get; init; }

        /// <summary>Gets the product identifier.</summary>
        /// <value>The product identifier.</value>
        public Guid ProductId { get; init; }

        /// <summary>Gets the stars.</summary>
        /// <value>The stars.</value>
        public int Stars { get; init; }

        /// <summary>Gets the comment.</summary>
        /// <value>The comment.</value>
        public string Comment { get; init; }
    }
}
