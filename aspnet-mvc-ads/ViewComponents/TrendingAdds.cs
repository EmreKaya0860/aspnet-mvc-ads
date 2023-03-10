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
		private readonly IAdvertService _advertService;

		public TrendingAdds(IService<Category> service, IAdvertService advertService)
        {
            _service = service;
            _advertService = advertService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var adverts = await _advertService.GetMostViewedAdverts();

            return View(adverts);
		}
	}
}
