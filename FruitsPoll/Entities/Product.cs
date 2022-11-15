namespace PollDog.API.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Brand> Brands { get; set; } = new List<Brand>();
    }
}
