namespace PollDog.API.Entities
{
    /// <summary>Product Dto</summary>
    public class Product
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>Gets or sets the brands.</summary>
        /// <value>The brands.</value>
        public List<Brand> Brands { get; set; } = new List<Brand>();
    }
}
