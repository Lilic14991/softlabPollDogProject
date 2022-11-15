
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Entities;
    using Swashbuckle.AspNetCore.Annotations;

    [Route("api/[controller]")]
    [ApiController]
    public abstract class BrandControllerBase : ControllerBase
    {
        /// <summary>
        /// Gets the brands.
        /// </summary>
        /// <returns> The list of brands. </returns>
        /// <response code="200"> Returns Ok if it's get item  </response>
        /// <response code="400"> If any data is incorrect  </response>
        [HttpGet]
        [SwaggerResponse(statusCode: 200, description: "Success",type: typeof(List<Brand>))]
        [SwaggerResponse(statusCode: 400, description: "BadRequest")]
        [SwaggerResponse(statusCode: 500, description: "InternalServerError")]
        // 401
        
        public abstract Task<IActionResult> GetBrands(); 
            
    }
}
