//-------------------------------------------------------------------------------
// <copyright file="Brand.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace WebAPI.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Brand
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the name of the brand.</summary>
        /// <value>The name of the brand.</value>
        public string BrandName { get; set; }
    }
}
