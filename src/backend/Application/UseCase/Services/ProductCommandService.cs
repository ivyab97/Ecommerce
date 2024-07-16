using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class ProductCommandService : IProductCommandService
    {
        private readonly IProductCommand _command;
        private readonly IMapper _mapper;

        public ProductCommandService(IProductCommand command, IMapper mapper)
        {
            _command = command;
            _mapper = mapper;
        }

        public async Task<ProductResponse> Create(ProductRequest request)
        {
            try
            {
                var product = _mapper.Map<Product>(request);
                product = await _command.Insert(product);

                var response = _mapper.Map<ProductResponse>(product);
                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw;}
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<ProductResponse> DeleteById(Guid id)
        {
            try
            {
                var product = await _command.Remove(id);
                return _mapper.Map<ProductResponse>(product);

            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw;}
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<ProductResponse> Update(Guid id, ProductRequest request)
        {
            try
            {
                var product = _mapper.Map<Product>(request);
                product.ProductId = id;
                product = await _command.Update(product);

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
