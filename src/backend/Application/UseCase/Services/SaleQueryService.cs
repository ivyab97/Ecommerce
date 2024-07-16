using Application.DTO.Error;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;

namespace Application.UseCase.Services
{
    public class SaleQueryService : ISaleQueryService
    {
        private readonly ISaleQuery _query;
        private readonly IMapper _mapper;
        public SaleQueryService(ISaleQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<SaleGetResponse>> GetAll(DateTime? from, DateTime? to)
        {
            try
            {
                var products = await _query.GetAllByDate(from, to);
                List<SaleGetResponse> list = new();

                products.ForEach(item =>
                {
                    list.Add(new SaleGetResponse
                    {
                        id = item.SaleId,
                        totalPay = item.TotalPay,
                        totalQuantity = item.SaleProducts.Sum(sp => sp.Quantity),
                        date = item.Date
                    });
                });

                return list;
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw;}
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<SaleResponse> GetById(int id)
        {
            try
            {
                var sale = await _query.RecoveryById(id);

                var response = _mapper.Map<SaleResponse>(sale);
                response.totalQuantity = sale.SaleProducts.Sum(sp => sp.Quantity);
                sale.SaleProducts.ForEach(p =>
                {
                    response.products.Add(_mapper.Map<SaleProductResponse>(p));
                });

                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw;}
                throw new InternalServerErrorException(e.Message);
            }
        }
    }
}
