// -------------------------------------------------------------------------------
// <copyright file="SurveyResultControllerBase.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;
    using DTO = PollDog.API.DTO;

    /// <summary>SurveyResult Controller base abstract class.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public abstract class SurveyResultControllerBase : ControllerBase
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SurveyResultControllerBase" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultControllerBase(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        #endregion

        #region Public methods

        /// <summary>Gets the product average ratings.</summary>
        /// <returns>
        ///   The list of products with average rating.
        /// </returns>
        [HttpGet]
        [SwaggerOperation(OperationId= "GetProductAverageRatings", Summary="Get products by avarage rating")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<DTO.ProductAverageRating>), description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> GetProductAverageRatings();

        /// <summary>Creates the survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        [HttpPost]
        [SwaggerOperation(OperationId="Create", Summary="Create a survey result")]
        [SwaggerResponse(statusCode: 200, description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> Create(DTO.SurveyResultCreate surveyResult);

        #endregion
    }
}
