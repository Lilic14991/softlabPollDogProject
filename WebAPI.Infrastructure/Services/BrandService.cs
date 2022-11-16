
namespace WebAPI.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using WebAPI.Core.Models;
    using WebAPI.Core.Repositories;
    using WebAPI.Core.Services;

    public class BrandService : IBrandService
    {
        private readonly IServiceProvider serviceProvider;

        public BrandService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public async Task<IEnumerable<Brand>> GetBrands()
        {
            var brandsService = this.serviceProvider.GetRequiredService<IBrandRepository>();
            var brands = await brandsService.GetBrands();

            return brands;

        }
    }
}
