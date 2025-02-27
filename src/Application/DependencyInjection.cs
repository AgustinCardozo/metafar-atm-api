using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Options;
using Application.Repositories;
using Application.Services;
using Common.Repositories;
using Common.Repositories.Interfaces;
using Common.Services;
using Common.Services.Interfaces;
using Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions()
                .Configure<DbOption>(configuration.GetSection(DbOption.Key))
                .Configure<JwtOption>(configuration.GetSection(JwtOption.Jwt));

            services.AddDbContext<AtmContext>((serviceProvider, options) => {
                var dbOption = serviceProvider.GetRequiredService<IOptions<DbOption>>();
                options.UseSqlServer(dbOption.Value.DatabaseConnection);
            });

            services.AddJwtService(configuration);
            services.AddServices();
            services.AddRepositories();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ICuentaRepository, CuentaRepository>();
            services.AddScoped<IOperacionRepository, OperacionRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IOperacionService, OperacionService>();
            services.AddScoped<ICuentaService, CuentaService>();
            return services;
        }

        public static IServiceCollection AddJwtService(this IServiceCollection services, IConfiguration configuration)
        {
            var serviceProvider = services.BuildServiceProvider();
            var jwtOption = serviceProvider.GetRequiredService<IOptions<JwtOption>>();

            services
                .AddAuthentication(options => {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options => {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters 
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtOption.Value.Key)),
                        ValidateAudience = false,
                        ValidateIssuerSigningKey = true,
                        ValidateLifetime = true,
                        ValidateIssuer = false
                    };
                });
            services.AddAuthorization();
            services.AddSingleton<IJwtTokenService>(new JwtTokenService(configuration));
            return services;
        }
    }
}
