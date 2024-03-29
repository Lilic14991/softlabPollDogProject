﻿// -------------------------------------------------------------------------------
// <copyright file="ProductController.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Data.SqlClient;
    using PollDog.API.Controllers.Base;
    using Mapper = AutoMapper;
    using Models = WebAPI.Core.Models;
    using Services = WebAPI.Core.Services;

    /// <summary>Product controller.</summary>
    public class ProductController : ProductControllerBase
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="ProductController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public ProductController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        #endregion

        #region Public methods

        /// <summary>Gets the list of products by BrandId.</summary>
        /// <param name="brandId">Brand Id Guid identifier.</param>
        /// <returns>
        ///     Returns 200 status code with list of products by brandId.
        /// </returns>
        public async override Task<IActionResult> GetProductsByBrandId([FromRoute] Guid brandId)
        {
            try
            {
                // resolve services
                var productService = this.ServiceProvider.GetRequiredService<Services.IProductService>();
                var mapper = this.ServiceProvider.GetRequiredService<Mapper.IMapper>();

                var products = await productService.GetProductsByBrandId(brandId);

                if (products == null)
                {
                    return this.BadRequest();
                }

                var mappedResult = mapper.Map<List<Models.Product>, List<DTO.ProductResponse>>(products.ToList());

                return this.Ok(mappedResult);
            }
            catch (SqlException sex)
            {
                return this.InternalServerError(sex);
            }
            catch (Exception ex)
            {
                return this.InternalServerError(ex);
            }
        }

        #endregion
    }
}
