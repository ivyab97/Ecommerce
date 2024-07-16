namespace Domain.Entities
{
    public class SaleProduct
    {
        public int ShoppingCartId { get; set; }
        public int Sale { get; set; }
        public Guid Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int? Discount { get; set; }
        public Product ProductObject { get; set; }
        public Sale SaleObject { get; set; }

    }
}
