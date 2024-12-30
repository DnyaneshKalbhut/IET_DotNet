namespace _01MVCBasics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //flow of your application by 
            //writting Middleware components here....

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Welcome to MVC Core 6.0");
                await next(context);
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("\n hello! from Run method");
            });

            app.Run();
        }
    }
}
