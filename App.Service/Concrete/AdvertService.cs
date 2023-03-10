using App.Data;
using App.Data.Concrete;
using App.Data.Entity;
using App.Service.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Concrete
{
    public class AdvertService : AdvertRepository, IAdvertService
    {

        private readonly ICategoryService _categoryService;

        public AdvertService(DatabaseContext _context, ICategoryService categoryService) : base(_context)
        {
            _categoryService = categoryService;
        }

        public async Task ClickUpdating(int id)
        {
            var advert = await context.Adverts.Include(x => x.Category).FirstOrDefaultAsync(c => c.Id == id);
            advert.ClickCount++;
            foreach (var item in advert.Category)
            {
                item.ClickCount++;
                //await _categoryService.CategoryClickCounter(item.Id);
            }

            context.SaveChanges();
        }

        public async Task<List<Advert>> GetMostViewedAdverts()
        {
            var adverts = await context.Adverts.OrderByDescending(x => x.ClickCount).Include(x => x.Category).Take(5).ToListAsync();

            return adverts;
        }

    }
}
