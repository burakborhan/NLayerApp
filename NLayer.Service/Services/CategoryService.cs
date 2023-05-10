using AutoMapper;
using NLayer.Core.DTO_s;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.UnitOfWorks;
using NLayer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {

        private readonly ICategoryRepository repository;
        private readonly IMapper mapper;
        public CategoryService(IUnitOfWork unitOfWork, IGenericRepository<Category> genericRepository, IMapper mapper, ICategoryRepository repository) : base(unitOfWork, genericRepository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task<CustomResponseDTO<CategoryWithProductsDTO>> GetSingleCategoryByIdWithProducts(int categoryId)
        {
            var category = await repository.GetSingleCategoryByIdWithProductsAsync(categoryId);
            var categoryDto = mapper.Map<CategoryWithProductsDTO>(category);
            return CustomResponseDTO<CategoryWithProductsDTO>.Success(200,categoryDto);
        }
    }
}
