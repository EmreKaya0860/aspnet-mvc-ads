using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.Controllers
{
    public class AdvertController : Controller
    {
        public readonly ICategoryAdvertService _categoryAdvertService;
        public readonly IService<Category> _CategoryService;

		public AdvertController(ICategoryAdvertService categoryAdvertService, IService<Category> categoryService)
		{
			_categoryAdvertService = categoryAdvertService;
			_CategoryService = categoryService;
		}

		public async Task<IActionResult> Search( int CategoryId, string query = "")
        {
            var model = await _categoryAdvertService.GetAllAdvertsByCategory(CategoryId, query);

            ViewData["AllCategories"] = _CategoryService.GetAll();

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
