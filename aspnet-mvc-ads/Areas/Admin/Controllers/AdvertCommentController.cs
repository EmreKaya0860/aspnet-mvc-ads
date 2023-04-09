using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_ads.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdvertCommentController : Controller
    {
        private readonly IService<AdvertComment> _service;

        public AdvertCommentController(IService<AdvertComment> service)
        {
            _service = service;
        }


        // GET: AdvertCommentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdvertCommentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdvertCommentController/Create
        

        // POST: AdvertCommentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdvertComment advertcommet)
        {
            _service.Add(advertcommet);
            _service.SaveChanges();
            return Redirect("/Home");

        }

        // GET: AdvertCommentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdvertCommentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdvertCommentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdvertCommentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
