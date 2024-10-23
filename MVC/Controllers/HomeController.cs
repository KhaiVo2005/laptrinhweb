using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Services.Interface;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            // L?y danh s�ch s?n ph?m v� danh m?c t? c�c Service
            var products = _productService.GetAllProducts();
            var categories = _categoryService.GetAllCategories();

            // ?�ng g�i v�o ViewModel ho?c ViewData
            ViewData["Products"] = products;
            ViewData["Categories"] = categories;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
