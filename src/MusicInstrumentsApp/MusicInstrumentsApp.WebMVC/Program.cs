using MusicInstrumentsApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore; // Для DbContext

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Додавання DbContext до DI-контейнера
builder.Services.AddDbContext<MusicInstrumentsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MusicInstrumentsContext"),
        sqlOptions => sqlOptions.MigrationsAssembly(typeof(Program).Assembly.GetName().Name)));

var app = builder.Build();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();