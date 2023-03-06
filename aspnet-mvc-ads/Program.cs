using App.Data;
using App.Data.Abstract;
using App.Data.Concrete;
using App.Service.Abstract;
using App.Service.Concrete;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient(typeof(IService<>), typeof(Service<>));
builder.Services.AddTransient<ICategoryAdvertService, CategoryAdvertService>();
builder.Services.AddTransient<IAdvertListingService, AdvertListingService>();

builder.Services.AddTransient<IAdvertService, AdvertService>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();




var app = builder.Build();

//builder.Services.AddDbContext<DatabaseContext>();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
	  name: "Admin",
	  pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
	);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
