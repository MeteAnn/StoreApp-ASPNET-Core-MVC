using Microsoft.EntityFrameworkCore;
using Services;
using Services.Contracts;
using Repositories;
using Repositories.Contracts;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


builder.Services.AddDbContext<RepositoryContext>(options=>

{

    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
    
        b => b.MigrationsAssembly("StoreApp"));

});



builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddAutoMapper(typeof(Program));
var app = builder.Build();


app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapRazorPages();

});



app.Run();
