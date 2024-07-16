using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface ISaleCommandService : ICommandService<SaleRequest, SaleResponse, int>
    {
    }
}
