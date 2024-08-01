using Microsoft.EntityFrameworkCore;
using RNRITS.EMPLOYEECRUDAPP.Models;
using System.Data.SqlTypes;

namespace RNRITS.EMPLOYEECRUDAPP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddScoped<IEmployees, SQLDAL>();

            builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));

            builder.Services.AddSwaggerGen();

            // Add CORS policy to allow specific origins, headers, and methods
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowSpecificOrigins", policyBuilder =>
                {
                    policyBuilder.WithOrigins() // specify the allowed origin
                                 .AllowAnyHeader()
                                 .AllowAnyMethod()
                                 .AllowCredentials();
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

            app.UseCors("AllowSpecificOrigins"); // Apply the CORS policy

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
