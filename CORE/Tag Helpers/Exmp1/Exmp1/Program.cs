namespace Exmp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();


            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                   name: "Default",
                    pattern: "{controller}/{action}",
                    defaults: new { controller = "AddAccount", action = "Login" });


            app.MapControllerRoute(
                   name: "Index2",
                    pattern: "Rama/Sitha/Lava/Kusha",
                    defaults: new { controller = "AddAccount", action = "Show" });


            app.Run();
        }
    }
}
