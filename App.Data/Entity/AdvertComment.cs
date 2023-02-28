using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class AdvertComment : IAuiditEntity
	{
        public int Id { get; set; }

        public int? AdvertId { get; set; }

        public Advert? Advert { get; set; }

        public int userID { get; set; }
        public User? user { get; set; }

        [Display(Name="Yorum")]

        public string? Comment { get; set; }

        [Display(Name ="Durum")]
        public bool IsActive { get; set; }
    }
}
