﻿// -------------------------------------------------------------------------------
// <copyright file="IBrandService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WebAPI.Core.Models;

    /// <summary>Brand interface.</summary>
    public interface IBrandService
    {
        /// <summary>Gets the brands.</summary>
        /// <returns>
        ///   The list of Brands.
        /// </returns>
        Task<List<Brand>> GetBrands();
    }
}
