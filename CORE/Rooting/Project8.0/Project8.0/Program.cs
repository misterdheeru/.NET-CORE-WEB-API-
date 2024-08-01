namespace Project8._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            var app = builder.Build();


            app.UseStatusCodePages();


            app.MapControllerRoute(
                     name: "Index1",
                      pattern: "{controller}/{action}",
                      defaults: new { controller = "Home", action = "Index"  });

            app.MapControllerRoute(
                    name: "Index2",
                     pattern: "Rama/Sitha/Lava/Kusha/{id?}",
                     defaults: new { controller = "Home", action = "About" });

            app.Run();
        }
    }
}
