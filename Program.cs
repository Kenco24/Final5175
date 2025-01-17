
using Final5175.Data;
using Final5175.Data.Interfaces;
using Final5175.Data.Repositories;
using Final5175.Services.Interfaces;
using Final5175.Services.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;


namespace Final5175
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
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<FinalContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            builder.Services.AddScoped<IClientRepository, ClientRepository>();
            builder.Services.AddScoped<ICarRepository, CarRepository>();


            builder.Services.AddScoped<IClientService, ClientService>();           
            builder.Services.AddScoped<ICarService, CarService>();


            builder.Services.AddAutoMapper(typeof(Program));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
