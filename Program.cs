var builder = WebApplication.CreateBuilder(args);

// Додаємо MVC (контролери + views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware (обробка запитів)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Маршрутизація (куди йти при відкритті сайту)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();