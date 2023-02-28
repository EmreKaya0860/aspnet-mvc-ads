using App.Data;
using App.Data.Concrete;
using App.Data.Entity;
using App.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IAuiditEntity, new()
    {
        public Service(DatabaseContext _context) : base(_context)
        {
        }
    }
}
