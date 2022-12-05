// -------------------------------------------------------------------------------
// <copyright file="CreateProduct.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.DTO
{
    /// <summary>Create product DTO class.</summary>
    public class CreateProduct
    {
        /// <summary>Gets or sets the name of the product.</summary>
        /// <value>The name of the product.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the brands.</summary>
        /// <value>The brands.</value>
        public Brand Brand { get; set; }
    }
}
