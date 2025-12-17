using MeuProjeto.Application.Interface;
using MeuProjeto.Application.Services;
using MeuProjeto.Infrastructure;
using MeuProjeto.Infrastructure.Interface;
using MeuProjeto.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MeuProjeto.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IDespesaRepository, DespesaRepository>();
            builder.Services.AddScoped<IDespesaService, DespesaService>();

            builder.Services.AddDbContext<DespesaDbContext>(op =>
            {
                op.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MeuProjeto API v1");
                });
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
