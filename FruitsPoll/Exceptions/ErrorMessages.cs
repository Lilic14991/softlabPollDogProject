// -------------------------------------------------------------------------------
// <copyright file="ErrorMessages.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
using System.Runtime.CompilerServices;

namespace PollDog.API.Exceptions
{
    /// <summary>ErrorMessage class.</summary>
    public static class ErrorMessages
    {
        private static IConfiguration Configuration;

        public static IConfiguration ErrorDict
        {
            get
            {
                var messages = Configuration.GetSection("ErrorMessage");
                return messages;
            }
        }

        /// <summary>The SQL error dictionary.</summary>
        private static Dictionary<string, string> errorMessagesDict = new Dictionary<string, string>();
        //{
        //    { "BRAND_NAME_NOT_SPECIFIED", "Brand Name cannot be null or empty string." },
        //    { "BRAND_IDENTIFIER_IS_NOT_VALID", "Brand identifier cannto be null or empty string" },
        //    { "PRODUCT_NAME_NOT_SPECIFIED", "Product Name cannot be null or empty string." },
        //    { "PRODUCT_IDENTIFIER_IS_NOT_VALID", "Product identifier cannot be null or invalid guid." },
        //    { "RATING_CANNOT_BE_NULL", "Rating cannot have null value or less then 0." },
        //};

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
