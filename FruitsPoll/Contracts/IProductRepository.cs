﻿//-------------------------------------------------------------------------------
// <copyright file="IProductRepository.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Contracts
{
    using PollDog.API.Entities;
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
