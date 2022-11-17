//-------------------------------------------------------------------------------
// <copyright file="BrandMapper.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Mapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Entities = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>Static class Brand mapper</summary>
    public static class BrandMapper
    {
        #region Public methods

        /// <summary>Databases the brand to model brand.</summary>
        /// <param name="brand">The brand.</param>
        /// <returns>
        ///   <br />
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
                BrandName = brand.BrandName,
            };
        }

        #endregion
    }
}
