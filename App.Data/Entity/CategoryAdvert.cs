using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class CategoryAdvert : IAuiditEntity
	{
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public int? AdvertId { get; set; }
        public virtual Advert? Advert { get; set; }
    }
}
