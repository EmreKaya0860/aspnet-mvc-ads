using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Abstract
{
    public interface IAdvertListingRepository : IRepository<Advert>
    {
        int AddList(User user, Advert advert, List<AdvertImage> advertImage, List<Category> category);
    }
}
