using Microsoft.EntityFrameworkCore;
using WebModuleTry2.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IDataRepository, EFDataRepository>();

builder.Services.AddDbContext<EFDataContext>(
    op => op.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));



var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();


app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();
