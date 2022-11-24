// -------------------------------------------------------------------------------
// <copyright file="CreateProduct.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    ///   <para>CreateProduct model class.</para>
    /// </summary>
    public class CreateProduct
    {
        /// <summary>Gets or sets the name of the product.</summary>
        /// <value>The name of the product.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the brands.</summary>
        /// <value>The brands.</value>
        public List<Brand> Brands { get; set; } = new List<Brand>();
    }
}
