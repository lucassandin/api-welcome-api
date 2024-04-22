using Domain.WelcomeContext;
using Domain.WelcomeContext.Mappers;
using Microsoft.OpenApi.Models;

namespace RandomWelcome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.AllowAnyOrigin();
                    });
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Welcome API",
                    Description = "API retorna uma mensagem de boas vindas aleatória.",
                });
            });


            builder.Services.AddAutoMapper(typeof(WelcomeMapper));

            builder.Logging.AddConsole();

            builder.Services.AddApplication();

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            //app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();

            app.UseCors();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
