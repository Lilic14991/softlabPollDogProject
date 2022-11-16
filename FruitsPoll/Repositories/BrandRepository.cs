namespace PollDog.API.Repositories
{
    using Dapper;
    using PollDog.API.Context;
    using PollDog.API.Contracts;
    using PollDog.API.Dtos;

    /// <summary>Brand Repository</summary>
    public class BrandRepository : IBrandRepository
    {
        #region Context

        /// <summary>The context</summary>
        private readonly DapperContext _context;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="BrandRepository" /> class.</summary>
        /// <param name="context">The context.</param>
        public BrandRepository(DapperContext context)
        {
            _context = context;
        }

        #endregion

        #region GetMethods

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

        #endregion
    }
}
