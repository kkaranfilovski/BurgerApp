using AutoMapper;
using BurgerApp.Helpers;
using BurgerApp.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(OrderMapper));
builder.Services.AddControllersWithViews();
builder.Services.InjectServices();
builder.Services.InjectRepositories();

string connString = builder.Configuration.GetConnectionString("BurgerAppDbConnection");
builder.Services.InjectDbContext(connString);

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
