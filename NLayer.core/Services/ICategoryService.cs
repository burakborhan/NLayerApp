using NLayer.Core.DTO_s;
using NLayer.Core.Models;
using NLayer.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDTO<CategoryWithProductsDTO>> GetSingleCategoryByIdWithProducts(int categoryId);
    }
}
