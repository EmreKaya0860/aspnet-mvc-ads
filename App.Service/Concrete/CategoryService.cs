using App.Data;
using App.Data.Concrete;
using App.Service.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Concrete
{
    public class CategoryService : CategoryRepository, ICategoryService
    {
        public CategoryService(DatabaseContext _context) : base(_context)
        {
        }

        public async Task CategoryClickCounter(int id)
        {
            var category = await context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            category.ClickCount++;
            context.SaveChanges();
        }
    }
}
