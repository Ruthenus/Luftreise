using Luftreise.Infrastructure;
<<<<<<< HEAD
using Luftreise.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> 595becd4d01a77026a22bab0118abd03b0a43f8b

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession();

builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

<<<<<<< HEAD

using (var scope = app.Services.CreateScope())
{
  var dbContext = scope.ServiceProvider.GetRequiredService<LuftreiseDbContext>();
  await DbSeeder.SeedAsync(dbContext);

}
=======
>>>>>>> 595becd4d01a77026a22bab0118abd03b0a43f8b
app.UseStaticFiles();
app.UseRouting();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

<<<<<<< HEAD
app.Run();
=======
app.Run();
>>>>>>> 595becd4d01a77026a22bab0118abd03b0a43f8b
