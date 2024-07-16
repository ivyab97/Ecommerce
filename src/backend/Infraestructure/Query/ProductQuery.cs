using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class ProductQuery : IProductQuery
    {
        private readonly AppDbContext _context;

        public ProductQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Paged<Product>> RecoveryAll(Parameters parameters, string? name, List<int>? categories)
        {
            try
            {
                IQueryable<Product> products = _context.Products.Include(p => p.CategoryObject);

                if (!string.IsNullOrEmpty(name))
                {
                    products = products.Where(p => p.Name.Contains(name));
                }

                if (categories != null && categories.Any())
                {
                    products = products.Where(p => categories.Contains(p.Category));
                }

                return await Paged<Product>.ToPagedAsync(products, parameters.offset, parameters.limit);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> RecoveryById(Guid id)
        {
            try
            {
                var product = await _context.Products
                .Include(c => c.CategoryObject)
                .FirstOrDefaultAsync(p => (p.ProductId == id));

                if (product == null)
                {
                    throw new NotFoundException("La Product con el ID " + id + " no fue encontrado.");
                }
                return product;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
