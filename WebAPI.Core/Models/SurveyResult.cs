// -------------------------------------------------------------------------------
// <copyright file="SurveyResult.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Models
{
    using System;

    /// <summary>class SurveyResult.</summary>
    public record SurveyResult
    {
        /// <summary>Gets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid Id { get; init; }

        /// <summary>Gets the stars.</summary>
        /// <value>The stars.</value>
        public int Stars { get; init; }

        /// <summary>Gets the comment.</summary>
        /// <value>The comment.</value>
        public string Comment { get; init; }

        /// <summary>Gets the product.</summary>
        /// <value>The product.</value>
        public Product Product { get; init; }
    }
}
