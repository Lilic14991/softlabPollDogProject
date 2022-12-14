// -------------------------------------------------------------------------------
// <copyright file="SqlExceptionHelper.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.SqlExceptions
{
    using Microsoft.Data.SqlClient;

    /// <summary>SqlExceptionHelper class.</summary>
    public class SqlExceptionHelper : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="SqlExceptionHelper" /> class.</summary>
        public SqlExceptionHelper()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="SqlExceptionHelper" /> class.</summary>
        /// <param name="message">The message that describes the error.</param>
        public SqlExceptionHelper(string message)
            : base(message)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="SqlExceptionHelper" /> class.</summary>
        /// <param name="message">The message.</param>
        /// <param name="sqlException">The SQL exception.</param>
        public SqlExceptionHelper(string message, SqlException sqlException)
            : base(message, sqlException)
        {
        }
    }
}
