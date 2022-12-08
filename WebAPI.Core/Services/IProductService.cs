// -------------------------------------------------------------------------------
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
        /// <param name="brandId">Brand Id Guid identifier.</param>
        /// <returns>The list of products by BrandId.</returns>
        Task<List<Models.Product>> GetProductsByBrandId(Guid brandId);

        /// <summary>Creates the specified product.</summary>
        /// <param name="product">The product.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        Task Create(Models.Product product);
    }
}
