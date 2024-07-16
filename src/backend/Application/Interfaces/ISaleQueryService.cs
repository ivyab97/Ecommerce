using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface ISaleQueryService : IQueryService<SaleResponse, int>
    {
        Task<List<SaleGetResponse>> GetAll(DateTime? from, DateTime? to);
    }
}
