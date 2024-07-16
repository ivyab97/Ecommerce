using Application.DTO.Request;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISaleCommand
    {
        Task<Sale> Insert(Sale sale);
    }
}
