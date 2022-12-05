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
        ///   Return list of Products.
        /// </returns>
        Task<IEnumerable<Product>> GetProducts();

        /// <summary>Creates the product.</summary>
        /// <param name="brandId">Brand Id Guid parameter.</param>
        /// <param name="name"> string parameter for name of product.</param>
        /// <returns>
        ///   Return Task.
        /// </returns>
        Task Create(Guid brandId, string name);
    }
}
