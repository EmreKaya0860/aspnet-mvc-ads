using System.ComponentModel.DataAnnotations;

namespace App.Data.Entity
{
    public class Advert : IAuiditEntity
	{

        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(200), Display(Name = "İlan Başlığı")]
        public string Title { get; set; }


        [Display(Name = "İlan Açıklaması")]
        public string? Description { get; set; }
        public int ClickCount { get; set; } = 0;
        public int? UserId { get; set; }

        [Display(Name ="Fiyat")]
        public float Price { get; set; } 
       
        public virtual User? User { get; set; }

        
        public virtual List<AdvertComment>? AdvertComments { get; set; }

        public virtual List<AdvertImage>? AdvertImages { get; set; }

        public virtual List<Category>? Category { get; set; }

    }
}
