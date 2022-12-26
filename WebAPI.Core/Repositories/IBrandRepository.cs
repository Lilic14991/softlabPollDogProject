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
        /// <returns>
        ///     The list of Brands.
        /// </returns>
        Task<List<Brand>> GetBrands();
    }
}
