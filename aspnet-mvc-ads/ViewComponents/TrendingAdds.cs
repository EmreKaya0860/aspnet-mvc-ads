using App.Data.Entity;
using App.Service.Abstract;
using App.Service.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Linq.Expressions;

namespace aspnet_mvc_ads.ViewComponents
{
	public class TrendingAdds : ViewComponent
	{
		private readonly IService<Category> _service;

		public TrendingAdds(IService<Category> service)
		{
			_service = service;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var categories = await _service.GetAllAsync();
			//var x = categories.Adverts.OrderByDescending(x => x.ClickCount).Take(5).ToList();



            return View(categories);
		}
	}
}
