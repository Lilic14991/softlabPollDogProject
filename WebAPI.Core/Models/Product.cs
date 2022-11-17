//-------------------------------------------------------------------------------
// <copyright file="Product.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace WebAPI.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>Product class</summary>
    public class Product
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the name of the product.</summary>
        /// <value>The name of the product.</value>
        public string ProductName { get; set; }

        /// <summary>Gets or sets the brands.</summary>
        /// <value>The brands.</value>
        public List<Brand> Brands { get; set; } = new List<Brand>();
    }
}
