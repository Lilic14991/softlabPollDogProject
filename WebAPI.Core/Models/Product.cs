// -------------------------------------------------------------------------------
// <copyright file="Product.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Models
{
    using System;

    /// <summary>Product class.</summary>
    public class Product
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid? Id { get; set; }

        /// <summary>Gets or sets the name of the product.</summary>
        /// <value>The name of the product.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the average.</summary>
        /// <value>The average.</value>
        public double Average { get; set; }

        /// <summary>Gets or sets the brand.</summary>
        /// <value>The brand.</value>
        public Brand Brand { get; set; }
    }
}
