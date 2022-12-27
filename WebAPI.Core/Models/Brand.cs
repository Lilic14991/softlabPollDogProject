// -------------------------------------------------------------------------------
// <copyright file="Brand.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Models
{
    using System;

    /// <summary>Brand class.</summary>
    public record Brand
    {
        /// <summary>Gets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid? Id { get; init; }

        /// <summary>Gets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; init; }
    }
}
