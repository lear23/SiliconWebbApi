using Microsoft.OpenApi.Models;



namespace SiliconWebbApi.Configurations;

public static class SwaggerConfiguration
{
    public static void RegisterSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(x =>
        {
            x.SwaggerDoc("v1", new OpenApiInfo { Title = "Silicon Web Api", Version = "v1" });
            x.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Query,
                Type = SecuritySchemeType.ApiKey,
                Name = "ApiKey",
                Description = "Enter API-Key"

            });

            x.AddSecurityRequirement(new OpenApiSecurityRequirement
            {

                {
                       new OpenApiSecurityScheme
                       {
                            Reference = new OpenApiReference
                            {
                                Type= ReferenceType.SecurityScheme,
                                Id = "ApiKey"
                            }
                       },
                       Array.Empty<string>()

                }
            });


        });
    }



}

//using Microsoft.OpenApi.Models;

//namespace SiliconWebbApi.Configurations
//{
//    public static class SwaggerConfiguration
//    {
//        public static void RegisterSwagger(this IServiceCollection services)
//        {
//            services.AddSwaggerGen(x =>
//            {
//                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Silicon Web Api", Version = "v1" });

//                // Configuración de JWT
//                x.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//                {
//                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
//                    Name = "Authorization",
//                    In = ParameterLocation.Header,
//                    Type = SecuritySchemeType.Http,
//                    Scheme = "bearer",
//                    BearerFormat = "JWT"
//                });

//                // Añadir el requisito de seguridad JWT a nivel global
//                x.AddSecurityRequirement(new OpenApiSecurityRequirement
//                {
//                    {
//                        new OpenApiSecurityScheme
//                        {
//                            Reference = new OpenApiReference
//                            {
//                                Type = ReferenceType.SecurityScheme,
//                                Id = "Bearer"
//                            }
//                        },
//                        new List<string>()
//                    }
//                });

//                // Configuración de API Key
//                x.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
//                {
//                    In = ParameterLocation.Query,
//                    Type = SecuritySchemeType.ApiKey,
//                    Name = "ApiKey",
//                    Description = "Enter API-Key"
//                });

//                x.AddSecurityRequirement(new OpenApiSecurityRequirement
//                {
//                    {
//                        new OpenApiSecurityScheme
//                        {
//                            Reference = new OpenApiReference
//                            {
//                                Type = ReferenceType.SecurityScheme,
//                                Id = "ApiKey"
//                            }
//                        },
//                        Array.Empty<string>()
//                    }
//                });
//            });
//        }
//    }
//}

