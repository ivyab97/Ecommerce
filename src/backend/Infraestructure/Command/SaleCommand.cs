using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class SaleCommand : ISaleCommand
    {
        private readonly AppDbContext _context;

        public SaleCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Sale> Insert(Sale sale)
        {
            await _context.Sales.AddAsync(sale);
            await _context.SaveChangesAsync();

            var saleResponse = await _context.Sales
                .Include(s => s.SaleProducts)
                .FirstOrDefaultAsync(s => s.SaleId == sale.SaleId);

            return saleResponse;
        }
    }
}
