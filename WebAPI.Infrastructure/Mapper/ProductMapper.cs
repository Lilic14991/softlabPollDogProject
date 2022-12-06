// -------------------------------------------------------------------------------
// <copyright file="ProductMapper.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Mapper
{
    using DbModels = WebAPI.Infrastructure.DbModels;
    using Models = WebAPI.Core.Models;

    /// <summary>Product mapper class.</summary>
    public static class ProductMapper
    {
        #region Extension methods

        /// <summary>Databases the product to model product.</summary>
        /// <param name="product">The product.</param>
        /// <returns>
        ///   The new instance of Product model.
        /// </returns>
        public static Models.Product DatabaseProductToModelProduct(this DbModels.Product product)
        {
            if (product == null)
            {
                return null;
            }

            return new Models.Product
            {
                Id = product.Id,
                Name = product.Name,
                BrandName = product.Brand.Name,
            };
        }

        #endregion
    }
}
