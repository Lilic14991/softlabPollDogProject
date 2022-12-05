// -------------------------------------------------------------------------------
// <copyright file="SurveyResultController.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers
{
    using global::AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Controllers.Base;
    using WebAPI.Core.Services;
    using DTO = PollDog.API.DTO;
    using Models = WebAPI.Core.Models;

    /// <summary>SurveyResult Controller class.</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyResultController : SurveyResultControllerBase
    {
        /// <summary>Initializes a new instance of the <see cref="SurveyResultController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        /// <summary>Creates the survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>
        ///   Return Task of IActionResult.
        /// </returns>
        public async override Task<IActionResult> Create([FromBody] DTO.CreateSurveyResult surveyResult)
        {
            try
            {
                var surveyResultService = this.ServiceProvider.GetRequiredService<ISurveyResultService>();
                var mapper = this.ServiceProvider.GetRequiredService<IMapper>();
                var mappedResult = mapper.Map<DTO.CreateSurveyResult, Models.SurveyResult>(surveyResult);
                await surveyResultService.Create(mappedResult);

                return this.Ok();
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }

        /// <summary>Gets the product average ratings.</summary>
        /// <returns>
        ///   Return task of IActionResult.
        /// </returns>
        public async override Task<IActionResult> GetProductAverageRatings()
        {
            try
            {
                var surveyResultService = this.ServiceProvider.GetRequiredService<ISurveyResultService>();
                var mapper = this.ServiceProvider.GetRequiredService<IMapper>();
                var averageRatings = await surveyResultService.GetProductWithAverageRating();
                var mappedAverageResult = mapper.Map<IEnumerable<Models.ProductAverageRatings>, IEnumerable<DTO.ProductAverageRatings>>(averageRatings);

                return this.Ok(mappedAverageResult);
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }
    }
}
