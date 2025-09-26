using Demo.DAL.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demo.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Configure Servies : Add services to the DI container.

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // give CLR permission to inject this services if needed
            //builder.Services.AddScoped<ApplicationDbContext>();//register service 
             
            builder.Services.AddDbContext<ApplicationDbContext>(options => {
                //builder can access on appsetting.json , Dbcontext can't
                var conString = builder.Configuration["ConnectionString:DefaultString"];
                conString = builder.Configuration.GetSection("ConncectionString")["DefaultString"];
                conString = builder.Configuration.GetConnectionString("DefaultString");

                options.UseSqlServer(conString);
            });
            #endregion
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
        }
    }
}
