using App.Data.Entity;
using App.Service.Abstract;
using App.Service.Concrete;
using aspnet_mvc_ads.Models;
using aspnet_mvc_ads.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;


namespace aspnet_mvc_ads.Controllers
{
	public class AdvertController : Controller
	{
		public readonly ICategoryAdvertService _categoryAdvertService;
		public readonly IService<Category> _CategoryService;
		public readonly IAdvertService _advertService;
		public readonly IService<User> _UserService;
		public readonly IAdvertListingService _AdvertListingService;


        public AdvertController(ICategoryAdvertService categoryAdvertService, IService<Category> categoryService, IAdvertService advertService, IService<User> userService, IAdvertListingService advertListingService)
        {
            _categoryAdvertService = categoryAdvertService;
            _CategoryService = categoryService;
            _advertService = advertService;
            _UserService = userService;
            _AdvertListingService = advertListingService;
        }

        public async Task<IActionResult> Search(int CategoryId, string query = "")
		{
			var model = await _categoryAdvertService.GetAllAdvertsByCategory(CategoryId, query);

			ViewData["AllCategories"] = _CategoryService.GetAll();

			return View(model);


		}


		public IActionResult AddListing()
		{
			ViewData["Categories"] = _CategoryService.GetAll();
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> AddListing(AddListingViewModel addListingView, List<IFormFile>? Images)
		{
            ViewData["Categories"] = _CategoryService.GetAll();


            var user = _UserService.Get(a => a.Email == addListingView.User.Email);
			var category = _CategoryService.GetAll(c => c.Id == addListingView.Category.Id);

			//Image ekleme denemeleri
   //         List<string> ImagePaths = new List<string>();

   //         foreach (IFormFile item in Images)
			//{
			//	ImagePaths.Add(item.FileName);
			//	FileHelper.FileLoaderAsync(item, filePath: "/wwwroot/images/adverts");

   //         }

			//List<AdvertImage> advertImages = new List<AdvertImage>();

			//foreach (var image in ImagePaths)
			//{
			//	var advertImage = new AdvertImage();
			//	advertImage.Advert = addListingView.Advert;
			//	advertImage.ImagePath = image;
			//	advertImages.Add(advertImage);
			//}

            _AdvertListingService.AddList(user, addListingView.Advert, addListingView.AdvertImages, category);


            return RedirectToAction("Index", "Home");
		}

        public async Task<IActionResult> DetailAsync(int id)
		{
			//var advert = await _categoryAdvertService.                 _service.GetProductByCategoriesBrandsAsync(id);
			await _advertService.ClickUpdating(id);
			var advert= await _advertService.FindAsync(id);
			return View(advert);

		}
	}
}
