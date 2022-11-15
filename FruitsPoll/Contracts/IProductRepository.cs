
namespace PollDog.API.Contracts
{
    using PollDog.API.Entities;
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
