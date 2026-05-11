using SteCvp.Application.Interfaces;
using SteCvp.Application.Services;
using SteCvp.Infrastructure.Database;
using SteCvp.Infrastructure.Repositories;

namespace SteCvp.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<PokemonCardService>();
            builder.Services.AddScoped<IPokemonCardRepository, PokemonCardRepository>();
            builder.Services.AddScoped<DbConnectionFactory>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy => policy
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseHttpsRedirection();
            }
            app.UseCors("AllowAll");
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
