//-------------------------------------------------------------------------------
// <copyright file="SurveyResult.cs" company="SoftLab R&D">
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

    /// <summary>class SurveyResult</summary>
    public class SurveyResult
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the stars.</summary>
        /// <value>The stars.</value>
        public float Stars { get; set; }

        /// <summary>Gets or sets the comment.</summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }

        /// <summary>Gets or sets the products.</summary>
        /// <value>The products.</value>
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
