using App.Data.Entity;

namespace aspnet_mvc_ads.Models
{
	public class AddListingViewModel
	{
		public Advert Advert { get; set; }
		public List<AdvertImage>? AdvertImages { get; set; }
		public User? User { get; set; }
		public Category Category { get; set; }
	}
}
