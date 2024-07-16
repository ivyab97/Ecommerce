namespace Domain.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Category { get; set; }
        public int? Discount { get; set; }
        public string ImageUrl { get; set; }
        public Category CategoryObject { get; set; }
        public List<SaleProduct> SaleProductObjects { get; set; }
    }
}
