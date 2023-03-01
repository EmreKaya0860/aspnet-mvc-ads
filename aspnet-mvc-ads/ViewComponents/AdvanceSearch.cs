using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.ViewComponents
{
    public class AdvanceSearch : ViewComponent
    {
        private readonly IService<Category> _service;

        public AdvanceSearch(IService<Category> service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _service.GetAllAsync();

            return View(categories);
        }
    }
}
