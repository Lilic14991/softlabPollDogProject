namespace PollDog.API.Entities
{
    public class SurveyResult
    {
        public string Id { get; set; }
        public float Rating { get; set; }
        public string Comment { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
