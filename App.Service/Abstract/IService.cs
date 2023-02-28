using App.Data.Abstract;
using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IAuiditEntity, new()
    {
    }
}
