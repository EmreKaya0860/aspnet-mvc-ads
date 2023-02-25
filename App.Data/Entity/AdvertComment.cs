using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class AdvertComment 
    {
        public int Id { get; set; }

        public int? AdvertId { get; set; }

        public Advert? Advert { get; set; }

        
<<<<<<< HEAD

=======
>>>>>>> 62ed73831eaedecf80eaf61372fc306d9f2cb065
        [Display(Name="Yorum")]

        public string? Comment { get; set; }

        [Display(Name ="Durum")]
        public bool IsActive { get; set; }
    }
}
