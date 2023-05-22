using AutoMapper;
using NLayer.Core.DTO_s;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWork, IGenericRepository<Product> genericRepository, IMapper mapper, IProductRepository productRepository) : base(unitOfWork, genericRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<List<ProductWithCategoryDTO>> GetProductWithCategory()
        {
            var products = await _productRepository.GetProductWithCategory();
            var productsDto = _mapper.Map<List<ProductWithCategoryDTO>>(products);

            return productsDto;

        }
        public async Task<List<ProductWithCategoryDTO>> GetProductWithCategoryAndId(int id)
        {
            
            var products = await _productRepository.GetProductWithCategoryAndId(id);
            var productsDto = _mapper.Map<List<ProductWithCategoryDTO>>(products);

            return productsDto;
        }
    }
}
