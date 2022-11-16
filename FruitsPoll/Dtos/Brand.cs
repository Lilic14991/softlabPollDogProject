//-------------------------------------------------------------------------------
// <copyright file="Brand.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Dtos
{
    /// <summary> <see cref="Brand"/> class DTO</summary>
    public class Brand
    {
        #region Properties

        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        #endregion
    }
}
