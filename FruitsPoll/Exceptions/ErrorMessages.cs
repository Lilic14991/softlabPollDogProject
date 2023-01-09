// -------------------------------------------------------------------------------
// <copyright file="ErrorMessages.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Exceptions
{
    /// <summary>ErrorMessage class.</summary>
    public static class ErrorMessages
    {
        /// <summary>Gets or sets the configuration section.</summary>
        /// <value>The configuration section.</value>
        public static IConfigurationSection? ConfigurationSection { get; set; }

    /// <summary>Gets the exception message.</summary>
    /// <param name="message">string representing sql exception message.</param>
    /// <returns>Returns string message.</returns>
        public static string? GetExceptionMessage(string? message)
        {
            var errorMessageKeys = ErrorMessages.ConfigurationSection;

            if (errorMessageKeys == null)
            {
                return message;
            }

            if (message == null)
            {
                return null;
            }

            message = errorMessageKeys[message];
            return message;
        }
    }
}
