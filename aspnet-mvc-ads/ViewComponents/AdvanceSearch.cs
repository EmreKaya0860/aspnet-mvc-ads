using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.ViewComponents
{
    public class AdvanceSearch : ViewComponent
    {
        private readonly IService<CategoryAdvert> _service;

        public AdvanceSearch(IService<CategoryAdvert> service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(int CategoryID, string search)
        {
            return View(await _service.GetAllAsync(a=> a.CategoryId == CategoryID && a.Advert.Title == search));
        }
    }
}
