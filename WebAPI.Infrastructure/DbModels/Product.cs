// -------------------------------------------------------------------------------
// <copyright file="Product.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.DbModels
{
    using System;

    /// <summary>Product database model.</summary>
    public record Product
    {
        /// <summary>Gets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid Id { get; init; }

        /// <summary>Gets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>Gets the brand identifier.</summary>
        /// <value>The brand identifier.</value>
        public Guid BrandId { get; init; }
    }
}
