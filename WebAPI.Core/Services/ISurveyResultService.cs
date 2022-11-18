
namespace WebAPI.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WebAPI.Core.Models;

    public interface ISurveyResultService
    {
        Task Create(SurveyResult surveyResult);
    }
}
