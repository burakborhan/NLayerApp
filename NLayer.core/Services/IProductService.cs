using NLayer.Core.DTO_s;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<List<ProductWithCategoryDTO>> GetProductWithCategory();
        Task<List<ProductWithCategoryDTO>> GetProductWithCategoryAndId(int id);
    }
}
