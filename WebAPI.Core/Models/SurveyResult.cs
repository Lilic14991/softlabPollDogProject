// -------------------------------------------------------------------------------
// <copyright file="SurveyResult.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Models
{
    using System;

    /// <summary>class SurveyResult.</summary>
    public class SurveyResult
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid Id { get; set; }

        /// <summary>Gets or sets the stars.</summary>
        /// <value>The stars.</value>
        public int Stars { get; set; }

        /// <summary>Gets or sets the comment.</summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }

        /// <summary>Gets or sets the product.</summary>
        /// <value>The product.</value>
        public Product Product { get; set; }
    }
}
