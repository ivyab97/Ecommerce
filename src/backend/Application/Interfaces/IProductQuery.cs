using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProductQuery : IQuery<Product, Guid>
    {
        Task<Paged<Product>> RecoveryAll(Parameters parameters, string? name, List<int>? categories);
    }
}
