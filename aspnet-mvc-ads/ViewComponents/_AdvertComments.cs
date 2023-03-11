using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace aspnet_mvc_ads.ViewComponents
{
    public class _AdvertComments :ViewComponent
    {

        private readonly IService<AdvertComment> _service;

        public _AdvertComments(IService<AdvertComment> service)
        {
            _service = service;
        }


        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
          AdvertComment a=new AdvertComment();

            a.AdvertId=id;

            TempData["UserBilgisi"] = Request.Cookies["userguid"];
            return View(a);

        }




    }
}
