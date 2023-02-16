using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            var x= 12;
            return View();
        }
    }
}
