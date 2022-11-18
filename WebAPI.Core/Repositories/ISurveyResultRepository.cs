using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.Models;

namespace WebAPI.Core.Repositories
{
    public interface ISurveyResultRepository
    {
        Task Create(SurveyResult surveyResult);
    }
}
