namespace Application.DTO.Response
{
    public class ProductGetResponse
    {
        public Guid id { get; set; }
        public string? name { get; set; }
        public double price { get; set; }
        public int discount { get; set; }
        public string? imageUrl { get; set; }
        public string categoryName { get; set; }
    }
}
