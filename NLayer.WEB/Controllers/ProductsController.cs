using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;

namespace NLayer.WEB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;


        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var CustomResponse = await _productService.GetProductWithCategory();
            return View(CustomResponse.Data);
        }
    }
}
