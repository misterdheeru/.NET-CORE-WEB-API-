using CRUDEMPLOYEE.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDEMPLOYEE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddScoped<IEmployees, SQLDAL>();
            builder.Services.AddScoped<IPOSITION, POSITIONDAL>();

            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));
            builder.Services.AddSwaggerGen();

            // Add CORS services
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "Angular", configurePolicy: policyBuilder =>
                {
                    policyBuilder.WithOrigins("http://localhost:4200");
                    policyBuilder.AllowAnyHeader();
                    policyBuilder.AllowAnyMethod();
                    policyBuilder.AllowCredentials();
                });

                 
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            // Use CORS middleware
            app.UseCors("Angular"); // Make sure this is placed early

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
