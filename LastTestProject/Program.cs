using LastTestProject.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IDataRepository, EFDataRepository>();
builder.Services.AddDbContext<EFDatabaseContext>(db =>
    db.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

app.MapControllerRoute(
    name:"Default", 
    pattern:"{controller=Home}/{action=Index}");

app.Run();
