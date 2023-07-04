using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserBackend.Interfaces;
using UserBackend.Models;
using UserBackend.Services;

namespace UserBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IUsersService, UsersService>();
            builder.Services.AddDbContext<UserContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("UserContext")));
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}