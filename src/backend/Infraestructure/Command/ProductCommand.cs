using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class ProductCommand : IProductCommand
    {
        private readonly AppDbContext _context;

        public ProductCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Insert(Product product)
        {
            try
            {
                await _context.AddAsync(product);
                await _context.SaveChangesAsync();

                var productResponse = await _context.Products
                    .Include(c => c.CategoryObject)
                    .FirstOrDefaultAsync(p => (p.ProductId == product.ProductId));

                return productResponse;
            }
            catch (Exception e)
            {
                if (e.InnerException is SqlException sqlException)
                {
                    if (sqlException.Number == 547) // Exception si hay una violación de clave externa
                    {
                        throw new BadRequestException("Revise la información ingresada; el ID de la categoría debe corresponder a una categoría existente.");
                    }
                    if (sqlException.Number == 2601) // Exception si hay un duplicado (nombre)
                    {
                        throw new ConflictException("El nombre <" + product.Name + "> ya se encuentra registrado, ingrese otro diferente.");
                    }
                }
                throw;
            }
        }

        public async Task<Product> Remove(Guid id)
        {
            try
            {
                var product = await _context.Products
                .Include(c => c.CategoryObject)
                .FirstOrDefaultAsync(p => (p.ProductId == id));
                if (product == null)
                {
                    throw new NotFoundException("El Producto con el ID " + id + " no fue encontrado.");
                }
                _context.Remove(product);
                await _context.SaveChangesAsync();
                return product;
            }
            catch (Exception e)
            {
                if (e is DbUpdateException)
                {
                    throw new ConflictException("No se puede eliminar, el producto esta relacionado a otra ventas realizadas.");
                }
                throw;
            }
        }

        public async Task<Product> Update(Product product)
        {
            try
            {
                var productToUpdate = await _context.Products
                .Include(c => c.CategoryObject)
                .FirstOrDefaultAsync(p => p.ProductId == product.ProductId);

                if (productToUpdate == null)
                {
                    throw new NotFoundException("El producto con el ID " + product.ProductId + " no fue encontrado");
                }
                _context.Entry(productToUpdate).CurrentValues.SetValues(product);
                await _context.SaveChangesAsync();

                var updatedProduct = await _context.Products
                .Include(c => c.CategoryObject)
                .FirstOrDefaultAsync(p => p.ProductId == product.ProductId);

                return updatedProduct;
            }
            catch (Exception e)
            {
                if (e.InnerException is SqlException sqlException)
                {
                    if (sqlException.Number == 547) // Exception si hay una violación de clave externa
                    {
                        throw new BadRequestException("Revise la información ingresada; el ID de la categoría debe corresponder a una categoría existente.");
                    }
                    if (sqlException.Number == 2601) // Exception si hay un duplicado (nombre)
                    {
                        throw new ConflictException("El nombre <" + product.Name + "> ya se encuentra registrado, ingrese otro diferente.");
                    }
                }
                throw;
            }
        }
    }
}
