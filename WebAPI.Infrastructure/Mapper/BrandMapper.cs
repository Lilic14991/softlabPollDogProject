// -------------------------------------------------------------------------------
// <copyright file="BrandMapper.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Mapper
{
    using Entities = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>Static class Brand mapper.</summary>
    public static class BrandMapper
    {
        #region Extension methods

        /// <summary>Maps databases the brand to model brand.</summary>
        /// <param name="brand">The brand.</param>
        /// <returns>
        ///   Return new instance of Brand model.
        /// </returns>
        public static Models.Brand DatabaseBrandToModelBrand(this Entities.Brand brand)
        {
            if (brand == null)
            {
                return null;
            }

            return new Models.Brand
            {
                Id = brand.Id,
                Name = brand.Name,
            };
        }

        #endregion
    }
}
