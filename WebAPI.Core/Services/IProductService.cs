﻿// -------------------------------------------------------------------------------
// <copyright file="IProductService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models = WebAPI.Core.Models;

    /// <summary>Interface for product service.</summary>
    public interface IProductService
    {
        /// <summary>Gets the products.</summary>
        /// <returns>The list of products.</returns>
        Task<List<Models.Product>> GetProducts(Guid brandId);

        /// <summary>Creates the specified product.</summary>
        /// <param name="product">The product.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        Task Create(Models.Product product);
    }
}
