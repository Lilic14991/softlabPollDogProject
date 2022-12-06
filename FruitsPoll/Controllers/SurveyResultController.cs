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
    public class SurveyResultController : SurveyResultControllerBase
    {
        #region Fields

        /// <summary>The service provider</summary>
        private readonly IServiceProvider serviceProvider;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SurveyResultController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        #endregion

        /// <summary>Creates the survey result.</summary>
        /// <param name="surveyResult">The survey result.</param>
        /// <returns>
        ///   Returns task.
        /// </returns>
        public async override Task<IActionResult> Create([FromBody] DTO.SurveyResultCreate surveyResult)
        {
            try
            {
                // resolve services
                var surveyResultService = this.serviceProvider.GetRequiredService<ISurveyResultService>();

                // resolve services
                var mapper = this.serviceProvider.GetRequiredService<IMapper>();

                var mappedResult = mapper.Map<DTO.SurveyResultCreate, Models.SurveyResult>(surveyResult);
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
        ///   Returns 200 status code wtith list of products with average rating.
        /// </returns>
        public async override Task<IActionResult> GetProductAverageRatings()
        {
            try
            {
                // resolve services
                var surveyResultService = this.ServiceProvider.GetRequiredService<ISurveyResultService>();

                // resolve services
                var mapper = this.ServiceProvider.GetRequiredService<IMapper>();

                var averageRatings = await surveyResultService.GetProductWithAverageRating();
                var mappedAverageResult = mapper.Map<IEnumerable<Models.ProductAverageRating>,
                    IEnumerable<DTO.ProductAverageRating>>(averageRatings);

                return this.Ok(mappedAverageResult);
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }
    }
}
