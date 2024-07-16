namespace Application.DTO.Response
{
    public class SaleProductResponse
    {
        public int id { get; set; }
        public Guid productId { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public int discount { get; set; }
    }
}
