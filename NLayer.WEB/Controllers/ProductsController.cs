using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLayer.Core.DTO_s;
using NLayer.Core.Models;
using NLayer.Core.Services;
using NLayer.Service.Services;

namespace NLayer.WEB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetProductWithCategory());
        }

        public async Task<IActionResult> Save()
        {
            var categories = await _categoryService.GetAllAsync();

            var categoriesDto = _mapper.Map<List<CategoryDTO>>(categories);
            ViewBag.Categories = new SelectList(categoriesDto, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDTO productDTO)
        {

            if (ModelState.IsValid)
            {
                await _productService.AddAsync(_mapper.Map<Product>(productDTO));
                return RedirectToAction(nameof(Index));
            }
            var categories = await _categoryService.GetAllAsync();

            var categoriesDto = _mapper.Map<List<CategoryDTO>>(categories);
            ViewBag.Categories = new SelectList(categoriesDto, "Id", "Name");
            return View();
        }
        [ServiceFilter(typeof(NotFoundFilter<Product>))]
        public async Task<IActionResult>Update(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var categories = await _categoryService.GetAllAsync();

            var categoriesDto = _mapper.Map<List<CategoryDTO>>(categories);
            ViewBag.Categories = new SelectList(categoriesDto, "Id", "Name",product.CategoryId);

            return View(_mapper.Map<ProductDTO>(product));
        }
        [HttpPost]
        public async Task<IActionResult>Update(ProductDTO productDTO)
        {
            if (ModelState.IsValid)
            {
                await _productService.UpdateAsync(_mapper.Map<Product>(productDTO));
                return RedirectToAction(nameof(Index));
            }
            var categories = await _categoryService.GetAllAsync();

            var categoriesDto = _mapper.Map<List<CategoryDTO>>(categories.ToList());
            ViewBag.Categories = new SelectList(categoriesDto, "Id", "Name",productDTO.CategoryId);
            return View(productDTO);
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _productService.RemoveAsync(_mapper.Map<Product>(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
