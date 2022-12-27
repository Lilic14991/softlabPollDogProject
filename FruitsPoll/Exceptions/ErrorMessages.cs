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
    /// <summary>Gets the exception message.</summary>
    /// <param name="message">string representing sql exception message.</param>
    /// <returns>Returns string message.</returns>
        public static string GetExceptionMessage(string message)
        {
            var errorMessageKeys = AppSettingsConfig.Configuration.GetSection("ErrorMessages").Get<Dictionary<string, string>>();

            if (errorMessageKeys.ContainsKey(message))
            {
                message = errorMessageKeys[message];
            }
            else
            {
                message = "Database error";
            }

            return message;
        }
    }
}
