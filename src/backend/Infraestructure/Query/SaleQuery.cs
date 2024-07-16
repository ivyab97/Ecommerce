using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class SaleQuery : ISaleQuery
    {
        private readonly AppDbContext _context;

        public SaleQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Sale>> GetAllByDate(DateTime? from, DateTime? to)
        {
            try
            {
                IQueryable<Sale> sales = _context.Sales
                    .Include(s => s.SaleProducts);

                if (from != null)
                {
                    sales = sales.Where(s => s.Date >= from);
                }

                if (to != null)
                {
                    DateTime toDate = to.Value.Date.AddDays(1);
                    sales = sales.Where(s => s.Date < toDate);
                }
                return await sales.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Sale> RecoveryById(int id)
        {
            try
            {
                var sale = await _context.Sales
                .Include(sp => sp.SaleProducts)
                .FirstOrDefaultAsync(s => (s.SaleId == id));

                if (sale == null)
                {
                    throw new NotFoundException("La Venta con el ID " + id + " no fue encontrada.");
                }
                return sale;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
