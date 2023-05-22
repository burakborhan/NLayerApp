using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTO_s;
using NLayer.Core.Models;
using NLayer.Core.Repositories;

namespace NLayer.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductWithCategory()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
        public async Task<List<Product>> GetProductWithCategoryAndId(int id)
        {
            return await _context.Products.Include(x => x.Category).Where(x => x.Id ==  id).ToListAsync();
        }
    }
}
