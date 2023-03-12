using System.ComponentModel.DataAnnotations;

namespace aspnet_mvc_ads.Models
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "Bos birakalamaz")]
        [EmailAddress(ErrorMessage = "Uygun fornatta degil")]

        public string Email { get; set; }


        [Required(ErrorMessage = "Bos birakilanaz")]

        [DataType(DataType.Password, ErrorMessage = "uygun değil")]

        public string? NewPassword { get; set; }

    }
}
