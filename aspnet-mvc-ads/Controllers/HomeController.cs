using App.Data.Entity;
using App.Service.Abstract;
using App.Service.Concrete;
using aspnet_mvc_ads.Models;
using aspnet_mvc_ads.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aspnet_mvc_ads.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<Category> _CategoryService;
        private readonly IService<Advert> _AdvertService;

        public HomeController(IService<Category> categoryService, IService<Advert> advertService)
        {
            _CategoryService = categoryService;
            _AdvertService = advertService;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View(_CategoryService.GetAll());
        }
        public IActionResult AddListing()
        {

            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> AddListingAsync(Advert advert, IFormFile? AdvertImages)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            if (AdvertImages is not null) advert.AdvertImages = await FileHelper.FileLoaderAsync(AdvertImages);
        //            await _AdvertService.AddAsync(advert);
        //            await _AdvertService.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            ModelState.AddModelError("", "Hata Oluştu!");
        //        }

        //        return View(advert);
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}