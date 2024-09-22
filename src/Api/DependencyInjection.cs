using Domain.Consts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

namespace Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(service =>
            {
                service.SwaggerDoc("v1", GetOpenApiInfo("v1"));
                var jwtSecurityScheme = GetOpenApiSecurityScheme();
                service.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);
                service.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { jwtSecurityScheme, Array.Empty<string>() }
                });
            });
        }

        private static OpenApiInfo GetOpenApiInfo(string version)
        {
            return new OpenApiInfo
            {
                Title = "ATM.API",
                Version = version,
                Description = "Challenge Metafar",
                Contact = new OpenApiContact
                {
                    Name = "Metafar",
                    Url = new Uri("https://metafar.io/")
                }
            };
        }

        private static OpenApiSecurityScheme GetOpenApiSecurityScheme()
        {
            return new OpenApiSecurityScheme
            {
                Scheme = "bearer",
                BearerFormat = "JWT",
                Name = "JWT Authentication",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Description = "Ingrese un token válido",
                Reference = new OpenApiReference
                {
                    Id = JwtBearerDefaults.AuthenticationScheme,
                    Type = ReferenceType.SecurityScheme
                }
            };
        }
    }
}
