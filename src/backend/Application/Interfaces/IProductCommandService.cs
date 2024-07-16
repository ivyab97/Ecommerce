using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IProductCommandService : ICommandService<ProductRequest, ProductResponse, Guid>
    {
        Task<ProductResponse> DeleteById(Guid id);
        Task<ProductResponse> Update(Guid id, ProductRequest request);
    }
}
