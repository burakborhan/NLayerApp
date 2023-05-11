﻿using NLayer.Core.DTO_s;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDTO<List<ProductWithCategoryDTO>>> GetProductWithCategory();
    }
}
