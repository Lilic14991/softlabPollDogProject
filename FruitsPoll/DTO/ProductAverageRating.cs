// -------------------------------------------------------------------------------
// <copyright file="ProductAverageRating.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.DTO
{
    /// <summary>Product with average rating.</summary>
    public record ProductAverageRating
    {
        /// <summary>Gets the name of the brand.</summary>
        /// <value>The name of the brand.</value>
        public string? BrandName { get; init; }

        /// <summary>Gets the name of the product.</summary>
        /// <value>The name of the product.</value>
        public string? ProductName { get; init; }

        /// <summary>Gets the average.</summary>
        /// <value>The average.</value>
        public double? Average { get; init; }
    }
}