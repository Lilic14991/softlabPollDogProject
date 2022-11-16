//-------------------------------------------------------------------------------
// <copyright file="IProductRepository.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Contracts
{
    using PollDog.API.Dtos;

    /// <summary>Product Repository Interface</summary>
    public interface IProductRepository
    {
        /// <summary>Gets the products.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        Task<IEnumerable<Product>> GetProducts();
    }
}
