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
    public class CategoryAdvertRepository : Repository<Category>, ICategoryAdvertRepository
    {
        public CategoryAdvertRepository(DatabaseContext _context) : base(_context)
        {
        }

        public async Task<IEnumerable<Category>> GetAllAdvertsByCategory(int id, string q)
        {
            return await context.Categories.Where(c => c.Id == id).Include(c => c.Adverts.Where(a => a.Title.Contains(q))).ToListAsync();
        }
    }
}
