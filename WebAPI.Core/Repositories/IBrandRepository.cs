// -------------------------------------------------------------------------------
// <copyright file="IBrandRepository.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Repositories
{
    using WebAPI.Core.Models;

    /// <summary>Interface repository for Brand.</summary>
    public interface IBrandRepository
    {
        /// <summary>Gets the brands.</summary>
        /// <returns>Return list of Brands.</returns>
        Task<IEnumerable<Brand>> GetBrands();

        /// <summary>Creates the specified name.</summary>
        /// <param name="name">The name.</param>
        /// <returns>
        ///   Return Task.
        /// </returns>
        Task Create(string name);
    }
}
