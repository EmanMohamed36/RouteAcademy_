namespace WebApplication01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Services In DI Container
            builder.Services.AddControllersWithViews();
            #endregion

            var app = builder.Build();

            #region Pipleline

            #endregion

            //app.MapGet("/", () => "Hello World!"); //Default
            //app.MapGet("/", () => "Hello World!"); -make error
            app.MapGet("/eman", () => "Hello Eman!"); //static segment
            app.MapGet("/{name}",async (context) =>
            {
                var name = context.GetRouteValue("name");
                await context.Response.WriteAsync($"Hello {name}"); //dynamic segment
            });

            app.MapGet("/miss{name}", async (context) =>
            {
                var name = context.GetRouteValue("name");
                await context.Response.WriteAsync($"Hello Miss {name}"); //mixed segment
            });
            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "default",
                pattern: "{Controller}/{Action}/{id?}",
                defaults:  new {Controller =  "Movies" , Action = "Index"}
                );
            app.Run();
        }
    }
}
