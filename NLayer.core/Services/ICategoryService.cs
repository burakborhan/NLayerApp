using NLayer.Core.DTO_s;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.Service.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDTO<CategoryWithProductsDTO>> GetSingleCategoryByIdWithProducts(int categoryId);
    }
}
