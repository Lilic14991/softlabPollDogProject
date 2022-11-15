//-------------------------------------------------------------------------------
// <copyright file="DapperContext.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Context
{
    using Microsoft.Data.SqlClient;
    using System.Data;

    /// <summary>ApplicationDbContext for dapper</summary>
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        /// <summary>Initializes a new instance of the <see cref="DapperContext" /> class.</summary>
        /// <param name="configuration">The configuration.</param>
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        /// <summary>Creates the connection.</summary>
        /// <returns>connection string</returns>
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
        
    }
}
