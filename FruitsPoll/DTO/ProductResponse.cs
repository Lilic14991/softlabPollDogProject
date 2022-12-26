﻿// -------------------------------------------------------------------------------
// <copyright file="ProductResponse.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.DTO
{
    /// <summary> <see cref="ProductResponse"/> class DTO.</summary>
    public class ProductResponse
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid? Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string? Name { get; set; }

        /// <summary>Gets or sets the brand identifier.</summary>
        /// <value>The brand identifier.</value>
        public Guid? BrandId { get; set; }
    }
}