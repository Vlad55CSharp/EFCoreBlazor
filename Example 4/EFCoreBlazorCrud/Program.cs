using EFCoreBlazor;

using EFCoreBlazorMigrations.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;


namespace EFCoreBlazorMigrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            //считываем из appsettings.json строку подключения
            string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
            //создаем фабрику
            if (connection != null)
            {
                builder.Services.AddDbContextFactory<ApplicationContext>(opt => opt.UseMySql(connection, ServerVersion.AutoDetect(connection)));
            }
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}