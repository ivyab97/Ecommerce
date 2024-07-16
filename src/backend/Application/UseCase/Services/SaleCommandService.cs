using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class SaleCommandService : ISaleCommandService
    {
        private readonly ISaleCommand _command;
        private readonly IProductQuery _productQuery;
        private readonly IMapper _mapper;

        public SaleCommandService(ISaleCommand command, IProductQuery productQuery, IMapper mapper)
        {
            _command = command;
            _productQuery = productQuery;
            _mapper = mapper;
        }

        public async Task<SaleResponse> Create(SaleRequest request)
        {
            double subtotal = 0;
            double totalDiscount = 0;
            double totalPay = 0;
            int totalQuantity = 0;

            try
            {
                var products = new List<SaleProduct>();

                await CheckProducts(request, products);
                CalculatePay(products, ref subtotal, ref totalDiscount, ref totalPay, request);
                totalQuantity = request.products.Sum(p => p.quantity); //Obtengo el total de products

                var sale = await _command.Insert(new Sale()
                {
                    TotalPay = totalPay,
                    Subtotal = subtotal,
                    TotalDiscount = totalDiscount,
                    Date = DateTime.Now,
                    SaleProducts = products
                });

                var response = _mapper.Map<SaleResponse>(sale);
                response.totalQuantity = totalQuantity;
                sale.SaleProducts.ForEach(p =>
                {
                    response.products.Add(_mapper.Map<SaleProductResponse>(p));
                });
                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    if(e is NotFoundException)
                    {
                        throw new BadRequestException("Verifique que los IDs de los productos ingresados sean correctos");
                    }
                    throw;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }


        private async Task CheckProducts(SaleRequest request, List<SaleProduct> products)
        {
            foreach (var item in request.products)
            {
                var product = await _productQuery.RecoveryById(item.productId); //Si no existe, este metodo lanza exception
                var saleProduct = _mapper.Map<SaleProduct>(product);
                saleProduct.Quantity = item.quantity;
                products.Add(saleProduct);
            }
        }


        private void CalculatePay(List<SaleProduct> products, ref double subtotal, ref double totalDiscount, ref double totalPay, SaleRequest request)
        {
            subtotal = products.Sum(sp => sp.Price * sp.Quantity);
            totalDiscount = products.Sum(sp => sp.Price * sp.Quantity * ((double)sp.Discount / 100));
            totalPay = (subtotal - totalDiscount) * 1.21;

            if (totalPay != request.totalPayed)
            {
                throw new BadRequestException("El pago total ingresado es incorrecto, por favor, realice la operación nuevamente.");
            }
        }
    }
}
