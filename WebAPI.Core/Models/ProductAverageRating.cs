// -------------------------------------------------------------------------------
// <copyright file="ProductAverageRating.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Models
{
    /// <summary>ProductAverageRating response class.</summary>
    public class ProductAverageRating
    {
        /// <summary>Gets or sets the name of the brand.</summary>
        /// <value>The name of the brand.</value>
        public string BrandName { get; set; }

        /// <summary>Gets or sets the name of the product.</summary>
        /// <value>The name of the product.</value>
        public string ProductName { get; set; }

        /// <summary>Gets or sets the average.</summary>
        /// <value>The average.</value>
        public double Average { get; set; }
    }
}
