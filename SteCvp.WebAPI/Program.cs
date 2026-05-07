
using SteCvp.Application.Interfaces;
using SteCvp.Application.Services;
using SteCvp.Infrastructure.Repositories;
using SteCvp.Infrastructure.Database;

namespace SteCvp.WebAPI
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
            builder.Services.AddScoped<PokemonCardService>();
            builder.Services.AddScoped<IPokemonCardRepository, PokemonCardRepository>();
            builder.Services.AddScoped<DbConnectionFactory>();

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

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    policy => policy
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            app.UseCors("AllowAll");

            builder.Services.AddCors(options =>

            {

                options.AddPolicy("AllowAll",

                    policy => policy

                        .AllowAnyOrigin()

                        .AllowAnyMethod()

                        .AllowAnyHeader());

            });

            // …

            app.UseCors("AllowAll");
        }
    }
}
