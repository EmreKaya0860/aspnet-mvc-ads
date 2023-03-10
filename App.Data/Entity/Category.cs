using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.Data.Entity
{
    public class Category : IAuiditEntity
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(100), Display(Name = "Kategori İsmi")]
        public string Name { get; set; }
        [StringLength(200), Display(Name = "Kategori Açıklaması")]
        public string Description { get; set; }
        public int ClickCount { get; set; }
        public virtual List<Advert>? Adverts{ get; set; }
    }
}
