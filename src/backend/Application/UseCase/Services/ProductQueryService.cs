using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class ProductQueryService : IProductQueryService
    {
        private readonly IProductQuery _query;
        private readonly IMapper _mapper;

        public ProductQueryService(IProductQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<ProductGetResponse>> GetAllPaged(List<int>? categories, string? name, int? limit, int offset)
        {
            try
            {
                if (limit <= 0 || offset < 0)
                {
                    throw new BadRequestException("Las QueryParams limit y offset no pueden ser números negativos. Limit no puede ser cero.");
                }
                Parameters parameters = new Parameters(offset, limit);
                Paged<Product> products = await _query.RecoveryAll(parameters, name, categories);

                List<ProductGetResponse> list = new();

                products.Data.ForEach(item =>
                {
                    var product = _mapper.Map<ProductGetResponse>(item);
                    list.Add(product);
                });

                return list;
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw;}
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<ProductResponse> GetById(Guid id)
        {
            try
            {
                var product = await _query.RecoveryById(id);

                var response = _mapper.Map<ProductResponse>(product);
                
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
