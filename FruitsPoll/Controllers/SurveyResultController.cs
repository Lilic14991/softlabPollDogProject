// -------------------------------------------------------------------------------
// <copyright file="SurveyResultController.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Controllers.Base;
    using DTO = PollDog.API.DTO;
    using Mapper = AutoMapper;
    using Models = WebAPI.Core.Models;
    using Services = WebAPI.Core.Services;

    /// <summary>SurveyResult Controller class.</summary>
    public class SurveyResultController : SurveyResultControllerBase
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="SurveyResultController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SurveyResultController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        #endregion

        #region Public methods

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
                var surveyResultService = this.ServiceProvider.GetRequiredService<Services.ISurveyResultService>();
                var mapper = this.ServiceProvider.GetRequiredService<Mapper.IMapper>();

                var mappedResult = mapper.Map<DTO.SurveyResultCreate, Models.SurveyResult>(surveyResult);
                await surveyResultService.Create(mappedResult);

                return this.Ok();
            }
            catch (Exception ex)
            {
                return this.InternalServerError(ex);
            }
        }

        /// <summary>Gets the product average ratings.</summary>
        /// <returns>
        ///   Returns 200 status code with list of products with average rating.
        /// </returns>
        public async override Task<IActionResult> GetProductAverageRatings()
        {
            try
            {
                // resolve services
                var surveyResultService = this.ServiceProvider.GetRequiredService<Services.ISurveyResultService>();
                var mapper = this.ServiceProvider.GetRequiredService<Mapper.IMapper>();

                var averageRatings = await surveyResultService.GetProductWithAverageRating();

                if (averageRatings == null)
                {
                    return this.NotFound();
                }

                var mappedAverageResult = mapper.Map<List<Models.Product>, List<DTO.ProductAverageRating>>(averageRatings.ToList());

                return this.Ok(mappedAverageResult);
            }
            catch (Exception ex)
            {
                return this.InternalServerError(ex);
            }
        }

        #endregion
    }
}
