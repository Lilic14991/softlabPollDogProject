// -------------------------------------------------------------------------------
// <copyright file="Product.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Models
{
    using System;

    /// <summary>Product class.</summary>
    public record Product
    {
        /// <summary>Gets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid? Id { get; init; }

        /// <summary>Gets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>Gets the average.</summary>
        /// <value>The average.</value>
        public double Average { get; init; }

        /// <summary>Gets the brand.</summary>
        /// <value>The brand.</value>
        public Brand Brand { get; init; }
    }
}
