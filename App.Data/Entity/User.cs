using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class User : IAuiditEntity
	{
        public int Id { get; set; }

        [Display(Name ="userGuid")]
        public string? userGuid { get; set; }

        [Display(Name = "İsim"), StringLength(100)]
        public string Name { get; set; }


        [Display(Name = "Email"), StringLength(200)]
        public string Email { get; set; }


        [Display(Name = "Şifre"), StringLength(100)]
        public string Password { get; set; }


        [Display(Name = "Telefon"), StringLength(11)]
        public string Phone { get; set; }


        [Display(Name = "Adres"), StringLength(200)]
        public string? Address { get; set; }

        public bool IsAdmin { get; set; }

        public virtual List<Advert>? Adverts { get; set; }
        public virtual List<Setting>? Settings { get; set; }

    }
}
