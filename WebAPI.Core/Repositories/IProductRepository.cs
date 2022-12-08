// -------------------------------------------------------------------------------
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
        /// <param name="brandId">Brand Id Guid parameter.</param>
        /// <returns>The list of Products by brandId.</returns>
        Task<List<Product>> GetProductsByBrandId(Guid brandId);

        /// <summary>Creates the product.</summary>
        /// <param name="brandId">Brand Id Guid parameter.</param>
        /// <param name="name"> string parameter for name of product.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        Task Create(Guid brandId, string name);
    }
}
