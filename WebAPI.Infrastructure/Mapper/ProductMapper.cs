// -------------------------------------------------------------------------------
// <copyright file="ProductMapper.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Mapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Entities = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>Product mapper class.</summary>
    public static class ProductMapper
    {
        #region Extension methods

        /// <summary>Databases the product to model product.</summary>
        /// <param name="product">The product.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static Models.Product DatabaseProductToModelProduct(this Entities.Product product)
        {
            if (product == null)
            {
                return null;
            }

            return new Models.Product
            {
                Id = product.Id,
                Name = product.Name,
            };
        }

        #endregion
    }
}
