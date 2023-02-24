using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class AdvertImage
    {
        public int Id { get; set; }

        public int AdvertId { get; set; }

        public Advert Advert { get; set; }

        [StringLength(200), Display(Name = "Resim Yolu")]
        public string ImagePath { get; set; }

    }
}
