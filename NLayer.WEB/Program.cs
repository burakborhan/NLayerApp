using Autofac;
using Autofac.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NLayer.Core.Models;
using NLayer.Data;
using NLayer.Service.Mapping;
using NLayer.Service.Validations;
using NLayer.WEB;
using NLayer.WEB.Modules;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductDTOValidator>());

builder.Services.AddIdentity<AppUser,AppRole>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.User.AllowedUserNameCharacters = "abcçdefgðhiýjklmnöopqrsþtüuvwxyzABCÇDEFÐGHIÝJKLMNOÖPQRSÞTUÜVWXYZ0123456789-._@+/ ";
})
        .AddEntityFrameworkStores<AppDbContext>()
        .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider);

builder.Services.AddScoped(typeof(NotFoundFilter<>));
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddRazorPages();


builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));


builder.Services.AddCors(options =>
{
    options.AddPolicy(
         "AllowOrigin",
         builder =>
builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});






CookieBuilder cookieBuilder = new CookieBuilder();
cookieBuilder.Name = "User";
cookieBuilder.HttpOnly = true;
cookieBuilder.SameSite = SameSiteMode.Lax;
cookieBuilder.SecurePolicy = CookieSecurePolicy.None;

builder.Services.ConfigureApplicationCookie(Options =>
{
    Options.LoginPath = new PathString("/Home/Login");
    Options.LogoutPath = new PathString("/Products/LogOut");
    Options.Cookie = cookieBuilder;
    Options.SlidingExpiration = true;
    Options.ExpireTimeSpan = TimeSpan.FromDays(14);

});


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

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}");

app.UseCors(x =>
{
    x.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
});

app.Run();
