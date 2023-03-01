using App.Data.Entity;
using App.Service.Abstract;
using aspnet_mvc_ads.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aspnet_mvc_ads.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<Category> _CategoryService;

        public HomeController(IService<Category> categoryService)
        {
            _CategoryService = categoryService;
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}