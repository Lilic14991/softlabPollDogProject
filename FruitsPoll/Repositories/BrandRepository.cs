//-------------------------------------------------------------------------------
// <copyright file="BrandRepository.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Repositories
{
    using Dapper;
    using PollDog.API.Context;
    using PollDog.API.Contracts;
    using PollDog.API.Dtos;

    /// <summary>Brand Repository</summary>
    public class BrandRepository : IBrandRepository
    {
        #region Fields

        /// <summary>The context</summary>
        private readonly DapperContext context;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandRepository" /> class.</summary>
        /// <param name="context">The context.</param>
        public BrandRepository(DapperContext context)
        {
            this.context = context;
        }

        #endregion

        #region Public methods

        /// <summary>Gets the brands.</summary>
        /// <returns>List of brands</returns>
        public async Task<IEnumerable<Brand>> GetBrands()
        {
            var query = "SELECT * FROM [Portfolio].[Brand]";

            using (var connection = this.context.CreateConnection())
            {
                var brands = await connection.QueryAsync<Brand>(query);
                return brands.ToList();
            }
        }

        #endregion
    }
}
