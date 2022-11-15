//-------------------------------------------------------------------------------
// <copyright file="BrandControllerBase.cs" company="SoftLab R&D">
//     Copyright (c) www.softlab.rs. All rights reserved.
// </copyright>
//-------------------------------------------------------------------------------
namespace PollDog.API.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Entities;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>BaseController for Brand</summary>
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
        /// <response code="401"> You are Unauthorized </response>
        /// <respose code="500"> Internal Server Error </respose>
        [HttpGet]
        [SwaggerOperation(OperationId = "GetBrands", Description = "gets list of brands")]
        [SwaggerResponse(statusCode: 200, description: "Success",type: typeof(List<Brand>))]
        [SwaggerResponse(statusCode: 400, description: "BadRequest")]
        [SwaggerResponse(statusCode: 401, description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, description: "InternalServerError")]
        
        public abstract Task<IActionResult> GetBrands(); 
            
    }
}
