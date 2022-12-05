// -------------------------------------------------------------------------------
// <copyright file="Brand.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.DbModels
{
    using System;

    /// <summary>class Entity Brand.</summary>
    public class Brand
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public Guid Id { get; set; }

        /// <summary>Gets or sets the name of the brand.</summary>
        /// <value>The name of the brand.</value>
        public string Name { get; set; }
    }
}
