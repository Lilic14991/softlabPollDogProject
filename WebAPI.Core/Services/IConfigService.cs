// -------------------------------------------------------------------------------
// <copyright file="IConfigService.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace WebAPI.Core.Services
{
    using Microsoft.Data.SqlClient;

    /// <summary>
    ///   <para>Interface IConfigService.</para>
    /// </summary>
    public interface IConfigService
    {
        /// <summary>Gets the connection.</summary>
        /// <value>The connection.</value>
        SqlConnection Connection { get; }
    }
}
