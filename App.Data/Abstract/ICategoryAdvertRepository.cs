using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Abstract
{
    public interface ICategoryAdvertRepository : IRepository<Category>
    {
        Task<IEnumerable<Category>> GetAllAdvertsByCategory(int id, string q);
    }
}
