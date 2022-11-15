namespace PollDog.API.Repositories
{
    using Dapper;
    using PollDog.API.Context;
    using PollDog.API.Contracts;
    using PollDog.API.Entities;

    public class BrandRepository : IBrandRepository
    {
        private readonly DapperContext _context;

        public BrandRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Brand>> GetBrands()
        {
            var query = "SELECT * FROM [Portfolio].[Brand]";

            using (var connection = _context.CreateConnection())
            {
                var brands = await connection.QueryAsync<Brand>(query);
                return brands.ToList();
            }
        }
    }
}
