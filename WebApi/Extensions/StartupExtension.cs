using AutoMapper;
using BussinesLayer.Interfaces.Authors;
using BussinesLayer.Interfaces.Books;
using BussinesLayer.Interfaces.Genres;
using DataLayer.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;
using BussinesLayer.Services.Authors;
using BussinesLayer.Services.Books;
using BussinesLayer.Services.Genres;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using DataLayer.Settings;
using System.Text;
using BussinesLayer.Services.Auth;
using BussinesLayer.Interfaces.Auth;

namespace WebApi.Extensions
{
    public static class StartupExtension
    {

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtSetting>(configuration.GetSection(nameof(JwtSetting)));

            services.AddDbContext<BooksDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("BooksDb")));
        }

        public static void ServicesImplementations(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IAuthorService, AuthorService>();
            services.AddTransient<IBooksService, BooksService>();
            services.AddTransient<IGenresService, GenresService>();
        }

        public static void ConfigureAutomapper(this IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(Startup));
            var config = new MapperConfiguration(cfg =>
            {
                var mainAssembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(c => c.GetName().Name == "DataLayer");
                cfg.AddMaps(mainAssembly);
                cfg.AllowNullCollections = true;
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo() { Title = "Books Api", Version = "v1" });
            });
        }


        public static void ConfigureSwaggerMiddleWare(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Books Api");
                opt.RoutePrefix = "Wiki";
            });
        }

        public static void ConfigureJwt(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
              options.TokenValidationParameters = new TokenValidationParameters
              {
                  ValidateIssuer = true,
                  ValidateAudience = true,
                  ValidateLifetime = false,
                  ValidateIssuerSigningKey = true,
                  ValidIssuer = configuration.GetSection(nameof(JwtSetting))[nameof(JwtSetting.ValidIssuer)],
                  ValidAudience = configuration.GetSection(nameof(JwtSetting))[nameof(JwtSetting.ValidAudience)],
                  IssuerSigningKey = new SymmetricSecurityKey(
                  Encoding.UTF8.GetBytes(configuration.GetSection(nameof(JwtSetting))[nameof(JwtSetting.SecretKey)])),
                  ClockSkew = TimeSpan.Zero
              });
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(build =>
             {
                 build.AddPolicy(nameof(Startup), _ => _.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
             });
        }
    }
}
