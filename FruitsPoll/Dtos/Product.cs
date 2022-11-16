//-------------------------------------------------------------------------------
// <copyright file="Product.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Dtos
{
    /// <summary> <see cref="Product"/> class DTO</summary>
    public class Product
    {
        #region Properties

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the brands.</summary>
        /// <value> <see cref="List{T}"/> List of Brands </value> 
        public List<Brand> Brands { get; set; } = new List<Brand>();

        #endregion
    }
}
