//-------------------------------------------------------------------------------
// <copyright file="IBrandRepository.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Contracts
{
    using PollDog.API.Dtos;

    /// <summary>Interface repository for Brand </summary>
    public interface IBrandRepository
    {
        #region Get Methods

        /// <summary>Gets the brands.</summary>
        /// <returns>List of brands</returns>
        Task<IEnumerable<Brand>> GetBrands();

        #endregion
    }
}
