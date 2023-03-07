using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace aspnet_mvc_ads.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly IService<Category> _service;

        public CategoriesController(IService<Category> service)
        {
            _service = service;
        }



        // GET: CategoriesController
        public async Task<ActionResult> Index()
        {
           var model=await  _service.GetAllAsync();

            return View(model);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {

            if(ModelState.IsValid)
            {
                try
                {
                    _service.Add(category);
                    _service.SaveChanges();
                    return RedirectToAction("Index");
                    
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu");
                }




            }

            return View(category); 

            



           
        }

        // GET: CategoriesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _service.FindAsync(id);

            return View(model);
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _service.Update(category);
                    _service.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu");
                   
                }




            }

            return View(category);

        }

        // GET: CategoriesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {

            var model= await _service.FindAsync(id);
            return View(model);
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                _service.Delete(category);
                _service.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
               
            }

            return View();
        }
    }
}
