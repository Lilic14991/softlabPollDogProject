﻿// -------------------------------------------------------------------------------
// <copyright file="IProductRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Repositories
{
    using WebAPI.Core.Models;

    /// <summary>Product Repository Interface.</summary>
    public interface IProductRepository
    {
        /// <summary>Gets the products.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        Task<IEnumerable<Product>> GetProducts();
    }
}
