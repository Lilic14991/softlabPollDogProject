namespace PollDog.API.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using PollDog.API.Controllers.Base;
    using PollDog.API.DTO;
    using WebAPI.Core.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class SurveyResultController : SurveyResultControllerBase
    {
        public SurveyResultController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public async override Task<IActionResult> CreateSurveyResult([FromBody] SurveyResult surveyResult)
        {
            try
            {
                var surveyResultService = this.ServiceProvider.GetRequiredService<ISurveyResultService>();
               // var data = await surveyResultService.CreateSurveyResult(surveyResult);

               // if (data == null)
                {
                    return this.NotFound();
                }

             //   return this.Ok(data);
            }
            catch (Exception ex)
            {
                return this.StatusCode(500, ex.Message);
            }
        }

        public override Task<IActionResult> GetProductAverageRatings()
        {
            throw new NotImplementedException();
        }
    }
}
