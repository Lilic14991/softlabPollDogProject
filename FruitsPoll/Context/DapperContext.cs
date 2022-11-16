//-------------------------------------------------------------------------------
// <copyright file="DapperContext.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Context
{
    using System.Data;
    using Microsoft.Data.SqlClient;

    /// <summary> ApplicationDBContext for Dapper </summary>
    public class DapperContext
    {
        #region Private Fields

        /// <summary>The configuration</summary>
        private readonly IConfiguration configuration;

        /// <summary>The connection string</summary>
        private readonly string connectionString;

        #endregion

        #region Constructor

        /// <summary> Initializes a new instance of the <see cref="DapperContext" /> class.</summary>
        /// <param name="configuration">The configuration.</param>
        public DapperContext(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        #endregion

        #region Connection Methods

        /// <summary> Creates the connection.</summary>
        /// <returns> Connection string </returns>
        public IDbConnection CreateConnection() => new SqlConnection(this.connectionString);

        #endregion
    }
}
