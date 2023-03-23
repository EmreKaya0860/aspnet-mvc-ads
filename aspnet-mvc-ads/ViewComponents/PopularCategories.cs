using App.Data.Entity;
using App.Service.Abstract;
using App.Service.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.ViewComponents
{
	public class PopularCategories : ViewComponent
	{
		private readonly IService<Category> _CategoryService;
		private readonly ICategoryService _categoriesServices;


        public PopularCategories(IService<Category> categoryService, ICategoryService categoriesService)
		{
			_CategoryService = categoryService;
            _categoriesServices = categoriesService;
        }

		public async Task<IViewComponentResult> InvokeAsync()
		{
		
			var categories =  await _categoriesServices.GetMostViewedCategory();

			return View(categories);
		}


	}
}
