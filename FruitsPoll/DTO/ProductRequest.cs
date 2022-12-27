// -------------------------------------------------------------------------------
// <copyright file="ProductRequest.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.DTO
{
    /// <summary>ProductRquest model class.</summary>
    public record class ProductRequest
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid? Id { get; init; }

        /// <summary>
        /// Gets the brand identifier.
        /// </summary>
        /// <value>
        /// The brand identifier.
        /// </value>
        public Guid? BrandId { get; init; }
    }
}
