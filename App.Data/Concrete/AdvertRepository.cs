using App.Data.Abstract;
using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Concrete
{
	public class AdvertRepository : Repository<Advert>, IAdvertRepository
	{
		public AdvertRepository(DatabaseContext _context) : base(_context)
		{
		}

		public async Task<Advert> GetAdvertWithOtherEntities(int id)
		{
			return await context.Adverts.Include(c => c.Category).Include(u => u.User).Include(d=> d.AdvertImages).Include(c=> c.AdvertComments).FirstOrDefaultAsync(a => a.Id == id);


		}
	}
}
