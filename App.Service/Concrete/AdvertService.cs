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
        public AdvertService(DatabaseContext _context) : base(_context)
        {
        }

        public async Task ClickUpdating(int id)
        {
            var advert = await context.Adverts.FirstOrDefaultAsync(c => c.Id == id);
            advert.ClickCount++;
            context.SaveChanges();
        }

        public async Task<List<Advert>> GetMostViewedAdverts()
        {
            var adverts = await context.Adverts.OrderByDescending(x => x.ClickCount).Include(x => x.Category).Take(5).ToListAsync();

            return adverts;
        }

    }
}
