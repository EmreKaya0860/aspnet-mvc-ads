using System.ComponentModel.DataAnnotations;

namespace App.Data.Entity
{
    public class Setting : IAuiditEntity
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(200), Display(Name = "Ayar Adı ")]
        public string Name { get; set; }

        [Display(Name = "Ayar Değeri") , StringLength(200)]
        public string? Value { get; set; }

        public int? UserId { get; set; }

        public virtual User? User { get; set; }


    }
}
