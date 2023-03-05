using App.Data.Abstract;
using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Concrete
{
    public class AdvertListingRepository : Repository<Advert>, IAdvertListingRepository
    {
        public AdvertListingRepository(DatabaseContext _context) : base(_context)
        {
        }

        public int AddList(User user, Advert advert, List<AdvertImage> advertImage, List<Category> category)
        {
            advert.User = user;
            advert.AdvertImages = advertImage;
            advert.Category = category;

            dbSet.Add(advert);

            return SaveChanges();
        }
    }
}
