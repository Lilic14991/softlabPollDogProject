

namespace WebAPI.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WebAPI.Core.Models;

    public interface IBrandService
    {
        Task<IEnumerable<Brand>> GetBrands();
    }
}
