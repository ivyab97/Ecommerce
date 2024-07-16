using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISaleQuery : IQuery<Sale, int>
    {
        Task<List<Sale>> GetAllByDate(DateTime? from, DateTime? to);
    }
}
