using System.Text;
using Application.Interfaces.Services;
using Domain.Consts;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddJwtService(configuration);
            services.AddDbContext<AtmContext>(options => options.UseSqlServer(configuration.GetConnectionString(Consts.ConfigKeys.DB_CONN)));
            return services;
        }

        public static IServiceCollection AddJwtService(this IServiceCollection services, IConfiguration configuration)
        {
            string jwtKey = configuration.GetSection(Consts.ConfigKeys.JWT).GetValue(Consts.ConfigKeys.KEY, string.Empty);
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtKey)),
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
