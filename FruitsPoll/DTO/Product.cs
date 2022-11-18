// -------------------------------------------------------------------------------
// <copyright file="Product.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.DTO
{
    /// <summary> <see cref="Product"/> class DTO.</summary>
    public class Product
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the brands.</summary>
        /// <value>  List of Brands.</value>
        public List<Brand> Brands { get; set; } = new List<Brand>();
    }
}
