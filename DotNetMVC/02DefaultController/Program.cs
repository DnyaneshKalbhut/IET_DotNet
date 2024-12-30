using Microsoft.AspNetCore.Mvc;

namespace _02DefaultController
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();


            //app.MapDefaultControllerRoute();

            app.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=Admin}/{action=Index}/{id?}"   
                );
             

            app.Run();
        }
    }
}
