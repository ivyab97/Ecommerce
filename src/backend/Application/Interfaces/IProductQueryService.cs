using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IProductQueryService : IQueryService<ProductResponse, Guid>
    {
        Task<List<ProductGetResponse>> GetAllPaged(List<int>? categories, string? name, int? limit,  int offset);
    }
}
