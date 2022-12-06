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
        /// <returns>
        ///   The list of Products.
        /// </returns>
        Task<List<Product>> GetProducts(Guid brandId);

        /// <summary>Creates the product.</summary>
        /// <param name="brandId">Brand Id Guid parameter.</param>
        /// <param name="name"> string parameter for name of product.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        Task Create(Guid brandId, string name);
    }
}
