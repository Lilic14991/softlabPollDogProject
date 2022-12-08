﻿// -------------------------------------------------------------------------------
// <copyright file="SurveyResultCreate.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.DTO
{
    /// <summary>SurveyResult DTO.</summary>
    public class SurveyResultCreate
    {
        /// <summary>Gets or sets the rating.</summary>
        /// <value>The rating.</value>
        public float Rating { get; set; }

        /// <summary>Gets or sets the comment.</summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }

        /// <summary>Gets or sets the products.</summary>
        /// <value>The products.</value>
        public List<Product> Products { get; set; } = new List<Product>();
    }
}