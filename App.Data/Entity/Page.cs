using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.Data.Entity
{
    public class Page : IAuiditEntity
	{
        public int Id { get; set; }


        [Display(Name = "Başlık"), StringLength(200)]
        public string Title { get; set; }



        [Display(Name = "İçerik")]
        public string Content { get; set; }



        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
    }
}
