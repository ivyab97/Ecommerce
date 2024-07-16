namespace Application.DTO.Response
{
    public class SaleResponse
    {
        public int id { get; set; }
        public double totalPay { get; set; }
        public int totalQuantity { get; set; }
        public double subtotal { get; set; }
        public double totalDiscount { get; set; }
        public double taxes { get; set; }
        public DateTime date { get; set; }
        public List<SaleProductResponse> products { get; set; }

        public SaleResponse()
        {
            products = new();
        }
    }
}
