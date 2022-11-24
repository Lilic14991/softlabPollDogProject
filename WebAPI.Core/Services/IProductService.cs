﻿// -------------------------------------------------------------------------------
// <copyright file="IProductService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models = WebAPI.Core.Models;

    /// <summary>Interface for product service.</summary>
    public interface IProductService
    {
        /// <summary>Gets the products.</summary>
        /// <returns>List of products.</returns>
        Task<IEnumerable<Models.Product>> GetProducts();

        /// <summary>Creates the specified product.</summary>
        /// <param name="product">The product.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        Task Create(Models.CreateProduct product);
    }
}
