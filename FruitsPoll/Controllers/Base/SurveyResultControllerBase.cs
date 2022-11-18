namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.DTO;
    using Swashbuckle.AspNetCore.Annotations;

    [Route("api/[controller]")]
    [ApiController]
    public abstract class SurveyResultControllerBase : ControllerBase
    {
        public SurveyResultControllerBase(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        [HttpGet]
        [SwaggerOperation(OperationId= "GetProductAverageRatings", Summary="get products by avarage rating")]
        [SwaggerResponse(statusCode: 200, description: "Success", type: typeof(SurveyResult))]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> GetProductAverageRatings();

        [HttpPost]
        [SwaggerOperation(OperationId="CreateSurveyResult", Summary="create a survey result")]
        [SwaggerResponse(statusCode: 201, description: "Created", type: typeof(SurveyResult))]
        [SwaggerResponse(statusCode: 400, description: "Bad Request")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "Internal Server Error")]
        public abstract Task<IActionResult> CreateSurveyResult(SurveyResult surveyResult);
    }
}
