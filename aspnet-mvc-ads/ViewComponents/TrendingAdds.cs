using App.Data.Entity;
using App.Service.Abstract;
using App.Service.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.ViewComponents
{
	public class TrendingAdds : ViewComponent
	{
		private readonly IService<Advert> _AdvertService;

		public TrendingAdds(IService<Advert> advertService)
		{
			_AdvertService = advertService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var adverts = await _AdvertService.GetAllAsync();

			return View(adverts);
		}
	}
}
