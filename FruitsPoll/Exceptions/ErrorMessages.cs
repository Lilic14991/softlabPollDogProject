﻿// -------------------------------------------------------------------------------
// <copyright file="ErrorMessages.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Exceptions
{
    /// <summary>ErrorMessage class.</summary>
    public static class ErrorMessages
    {
        /// <summary>The SQL error dictionary.</summary>
        private static Dictionary<string, string> errorMessagesDict = new Dictionary<string, string>()
        {
            { "BRAND_NAME_NOT_SPECIFIED", "Brand Name cannot be null or empty string." },
            { "BRAND_ID_IS_NOT_VALID", "BrandId is not valid Guid." },
            { "PRODUCT_NAME_NOT_SPECIFIED", "Product Name cannot be null or empty string." },
        };

        /// <summary>Gets the exception message.</summary>
        /// <param name="message">string representing sql exception message.</param>
        /// <returns>Returns string message.</returns>
        public static string GetExceptionMessage(string message)
        {
            if (errorMessagesDict.ContainsKey(message))
            {
                message = errorMessagesDict[message];
            }
            else
            {
                message = "Database error";
            }

            return message;
        }
    }
}