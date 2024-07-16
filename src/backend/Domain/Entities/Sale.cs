namespace Domain.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public double TotalPay { get; set; }
        public double Subtotal { get; set; }
        public double TotalDiscount { get; set; }
        public double Taxes { get; set; }
        public DateTime Date { get; set; }
        public List<SaleProduct> SaleProducts { get; set; }

    }
}
