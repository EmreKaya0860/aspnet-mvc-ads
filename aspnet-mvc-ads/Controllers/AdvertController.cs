using App.Data.Entity;
using App.Service.Abstract;
using App.Service.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.Controllers
{
	public class AdvertController : Controller
	{
		public readonly ICategoryAdvertService _categoryAdvertService;
		public readonly IService<Category> _CategoryService;
		public readonly IAdvertService _advertService;


		public AdvertController(ICategoryAdvertService categoryAdvertService, IService<Category> categoryService, IAdvertService advertService)
		{
			_categoryAdvertService = categoryAdvertService;
			_CategoryService = categoryService;
			_advertService = advertService;
		}

		public async Task<IActionResult> Search(int CategoryId, string query = "")
		{
			var model = await _categoryAdvertService.GetAllAdvertsByCategory(CategoryId, query);

			ViewData["AllCategories"] = _CategoryService.GetAll();

			return View(model);
		}


		public IActionResult AddListing()
		{
			return View();
		}


		public async Task<IActionResult> DetailAsync(int id)
		{
			//var advert = await _categoryAdvertService.                 _service.GetProductByCategoriesBrandsAsync(id);
			await _advertService.ClickUpdating(id);
			var advert= await _advertService.FindAsync(id);
			return View(advert);

		}
	}
}
