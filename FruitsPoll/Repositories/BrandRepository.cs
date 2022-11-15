namespace PollDog.API.Repositories
{
    using Dapper;
    using PollDog.API.Context;
    using PollDog.API.Contracts;
    using PollDog.API.Entities;

    /// <summary>Brand Repository</summary>
    public class BrandRepository : IBrandRepository
    {
        private readonly DapperContext _context;

        /// <summary>Initializes a new instance of the <see cref="BrandRepository" /> class.</summary>
        /// <param name="context">The context.</param>
        public BrandRepository(DapperContext context)
        {
            _context = context;
        }

        /// <summary>Gets the brands.</summary>
        /// <returns>List of brands</returns>
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
