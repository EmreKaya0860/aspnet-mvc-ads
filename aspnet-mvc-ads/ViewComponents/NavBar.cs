using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.ViewComponents
{
	public class NavBar : ViewComponent
	{
		private readonly IService<Category> _CategoryService;

		public NavBar(IService<Category> categoryService)
		{
			_CategoryService = categoryService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
            if (Request.Cookies["userguid"] is not null)
            {
                TempData["UserBilgisi"] = Request.Cookies["userguid"];
            }
            else
            {
                TempData["UserBilgisi"] = null;
            }
            return View(await _CategoryService.GetAllAsync());
		}
	}
}
