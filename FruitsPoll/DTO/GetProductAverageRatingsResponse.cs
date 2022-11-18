
namespace WebAPI.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GetProductAverageRatingsResponse
    {
        public string BrandName { get; set; }

        public string ProductName { get; set; }

        public double Average { get; set; }
    }
}
