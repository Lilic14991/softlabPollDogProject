
namespace PollDog.API.Contracts
{
    using PollDog.API.Entities;

    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetBrands();
    }
}
