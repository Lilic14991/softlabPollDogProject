// -------------------------------------------------------------------------------
// <copyright file="ConfigService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Infrastructure.Services
{
    using System;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Services;

    /// <summary>Configuration service for connection  string.</summary>
    public class ConfigService : IConfigService
    {
        /// <summary>The service provider.</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>The configuration.</summary>
        private readonly IConfiguration configuration;

        /// <summary>Initializes a new instance of the <see cref="ConfigService" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="configuration">The configration.</param>
        public ConfigService(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            this.serviceProvider = serviceProvider;
            this.configuration = configuration;
            this.configuration = this.serviceProvider.GetRequiredService<IConfiguration>();
        }

        #region Public properties

        /// <summary>Gets the connection.</summary>
        /// <value>The connection.</value>
        public SqlConnection Connection
        {
            get
            {
                var connection = new SqlConnection(this.ConnectionString);
                return connection;
            }
        }

        /// <summary>Gets the connection string.</summary>
        /// <value>The connection string.</value>
        public string ConnectionString
        {
            get
            {
                var connString = this.configuration["ConnectionStrings:DefaultConnection"];
                return connString;
            }
        }

        #endregion
    }
}
