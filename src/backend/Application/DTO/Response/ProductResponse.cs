namespace Application.DTO.Response
{
    public class ProductResponse
    {
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public double price { get; set; }
        public int discount { get; set; }
        public string? imageUrl { get; set; }
        public Category category { get; set; }
    }
}
