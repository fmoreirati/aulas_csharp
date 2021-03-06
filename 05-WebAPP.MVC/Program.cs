using _05_WebAPP.MVC.Data;
using _05_WebAPP.MVC.Interfaces;
using _05_WebAPP.MVC.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

//Banco de dados
builder.Services.AddDbContext<EntityContext>(
    options =>
    options.UseNpgsql(
        configuration.GetConnectionString("TreinamentosDB")
        ?? throw new InvalidOperationException("Connection string not found.")
    )
);

//Dependencias
builder.Services.AddScoped<IUserService, UserService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
