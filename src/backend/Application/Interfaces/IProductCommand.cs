using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProductCommand : ICommand<Product, Guid>
    {
        Task<Product> Update(Product product);
        Task<Product> Remove(Guid id);
    }
}
