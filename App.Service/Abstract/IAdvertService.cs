using App.Data.Abstract;
using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Abstract
{
	public interface IAdvertService : IAdvertRepository
	{
		Task ClickUpdating(int id);
		Task<List<Advert>> GetMostViewedAdverts();
    }
}
