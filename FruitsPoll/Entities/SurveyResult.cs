﻿namespace PollDog.API.Entities
{
    /// <summary>SurveyResult Dto</summary>
    public class SurveyResult
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }
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
