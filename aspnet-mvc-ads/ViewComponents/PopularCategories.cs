using App.Data.Entity;
using App.Service.Abstract;
using App.Service.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.ViewComponents
{
	public class PopularCategories : ViewComponent
	{
		private readonly IService<Category> _CategoryService;

		public PopularCategories(IService<Category> categoryService)
		{
			_CategoryService = categoryService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var categories = await _CategoryService.GetAllAsync();

			return View(categories);
		}
	}
}
