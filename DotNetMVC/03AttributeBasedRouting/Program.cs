namespace _03AttributeBasedRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllers(); // enable Route based Routing

            app.Run();
        }
    }
}
