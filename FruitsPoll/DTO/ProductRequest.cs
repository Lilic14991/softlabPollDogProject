// -------------------------------------------------------------------------------
// <copyright file="ProductRequest.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.DTO
{
    /// <summary>ProductRquest model class.</summary>
    public class ProductRequest
    {
        /// <summary>Gets or sets the product identifier.</summary>
        /// <value>The product identifier.</value>
        public Guid? Id { get; set; }

        /// <summary>Gets or sets the brand identifier.</summary>
        /// <value>The brand identifier.</value>
        public Guid? BrandId { get; set; }
    }
}
