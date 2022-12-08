// -------------------------------------------------------------------------------
// <copyright file="PollDogException.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Middleware
{
    using System.Net;

    /// <summary>PollDog Exception class.</summary>
    public class PollDogException : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="PollDogException" /> class.</summary>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="code">The code.</param>
        public PollDogException(string errorMessage, HttpStatusCode code)
            : base(errorMessage)
        {
            this.Code = code;
        }

        /// <summary>Gets or sets the code.</summary>
        /// <value>The code.</value>
        public HttpStatusCode Code { get; set; }
    }
}
