// -------------------------------------------------------------------------------
// <copyright file="ProductService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Repositories;
    using WebAPI.Core.Services;
    using Models = WebAPI.Core.Models;

    /// <summary>Product service class.</summary>
    public class ProductService : IProductService
    {
        #region Fields

        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ProductService" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        #endregion

        #region Public methods

        /// <summary>Gets the products.</summary>
        /// <returns>List of products.</returns>
        public async Task<IEnumerable<Models.Product>> GetProducts()
        {
            var productsService = this.serviceProvider.GetRequiredService<IProductRepository>();
            var products = await productsService.GetProducts();

            return products;
        }

        /// <summary>Creates the specified product.</summary>
        /// <param name="product">The product.</param>
        /// <returns>representing the asynchronous operation.</returns>
        public async Task Create(Models.CreateProduct product)
        {
            var productService = this.serviceProvider.GetRequiredService<IProductRepository>();
            await productService.Create(product.Brands.Select(x => x.Id).FirstOrDefault(), product.Name);
        }

        #endregion
    }
}
