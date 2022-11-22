// -------------------------------------------------------------------------------
// <copyright file="GetProductAverageRatingsResponse.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>Product with average rating.</summary>
public class ProductAverageRatings
{
    /// <summary>Gets or sets the name of the brand.</summary>
    /// <value>The name of the brand.</value>
    public string BrandName { get; set; }

    /// <summary>Gets or sets the name of the product.</summary>
    /// <value>The name of the product.</value>
    public string ProductName { get; set; }

    /// <summary>Gets or sets the average.</summary>
    /// <value>The average.</value>
    public double Average { get; set; }
}
