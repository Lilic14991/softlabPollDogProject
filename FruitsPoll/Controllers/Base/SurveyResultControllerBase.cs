// -------------------------------------------------------------------------------
// <copyright file="SurveyResultControllerBase.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.DTO;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>SurveyResult Controller base abstract class.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public abstract class SurveyResultControllerBase : ControllerBase
    {
        /// <summary>Initializes a new instance of the <see cref="SurveyResultControllerBase" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultControllerBase(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        /// <summary>Gets the product average ratings.</summary>
        /// <returns>
        ///   Return task of IActionResult.
        /// </returns>
        [HttpGet]
        [SwaggerOperation(OperationId= "GetProductAverageRatings", Summary="Get products by avarage rating")]
        [SwaggerResponse(statusCode: 200, type: typeof(ProductAverageRatings), description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> GetProductAverageRatings();

        /// <summary>Creates the survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>
        ///   Returns task of IActionResult.
        /// </returns>
        [HttpPost]
        [SwaggerOperation(OperationId="CreateSurveyResult", Summary="Create a survey result")]
        [SwaggerResponse(statusCode: 200, type: typeof(CreateSurveyResult), description: "Success")]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> Create(CreateSurveyResult surveyResult);
    }
}
