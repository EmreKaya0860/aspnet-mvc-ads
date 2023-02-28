using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Advert> Adverts { get; set; }
		public DbSet<AdvertComment> AdvertComments { get; set; }
		public DbSet<AdvertImage> AdvertImages { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryAdvert> CategoryAdverts { get; set; }
		public DbSet<Page> Pages { get; set; }
		public DbSet<Setting> Settings { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;database=AspNetMVCAds;integrated security=true; TrustServerCertificate=True");
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasData(
				
				new User { 
					
					
					Id = 1, 
				Name="admin",
				Email="admin@blog.com",
				Password="123",
				Phone="2342323",
				Address="samsun",


				}
				
				
				);



			modelBuilder.Entity<Category>().HasData(

				new Category
				{


					Id = 1,
					Name="Teknoloji",
					Description="Teknolojik Ürünler"
				
					


				}


				);


			modelBuilder.Entity<Advert>().HasData(

				new Advert
				{


					Id = 1,
					Title="Iphone"
					
					



				}


				);






			//modelBuilder.Entity<Card>()
			//    .HasRequired(c => c.Stage)
			//    .WithMany()
			//    .WillCascadeOnDelete(false);

			//modelBuilder.Entity<Side>()
			//    .HasRequired(s => s.Stage)
			//    .WithMany()
			//    .WillCascadeOnDelete(false);
			base.OnModelCreating(modelBuilder);
		}

	}
}
