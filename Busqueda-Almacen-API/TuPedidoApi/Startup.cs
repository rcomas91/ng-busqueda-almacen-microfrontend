using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using TuPedidoApi.Utils;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.OpenApi.Models;
using Microsoft.OData.Edm;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using TuPedidoApi.Extentions;
using System.IO;
using Sistia.Models;
using winatm.Models;

namespace TuPedidoApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.TryAddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.TryAddTransient<IWebHostBuilder, WebHostBuilder>();
        

            //Add Cors
            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder2 =>
                {
                    builder2.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build();
                });
            });


            // Add framework services.
            services.AddDbContext<SistiaDB>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TuPedidoApiContext"),
                b => b.MigrationsAssembly("Sistia")));

            // Add framework services.
            services.AddDbContext<WinatmDB>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConexionTest"),
                b => b.MigrationsAssembly("Winatm")));

         
            services.AddAutoMapper();
            services.AddMvc().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());


            //Add Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            services.AddSwaggerGenNewtonsoftSupport(); // explicit opt-in - needs to be placed after AddSwaggerGen()

            services.AddMvcCore()
            .AddApiExplorer();


            //Add Odata
            services.AddOData();

        }

        //private static IEdmModel GetEdmModel()
        //{
        //    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
        //    builder.EntitySet<Order>("Orders");
        //    return builder.GetEdmModel();
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseExceptionHandler(
       builder =>
       {
           builder.Run(
                      async context =>
                   {

                       context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                       context.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                       var error = context.Features.Get<IExceptionHandlerFeature>();
                       if (error != null)
                       {
                           context.Response.AddApplicationError(error.Error.Message);
                           await context.Response.WriteAsync(error.Error.Message).ConfigureAwait(false);
                       }
                   });
       });

            // Redirect non api calls to angular app and let the routing to be managed there. 
            app.Use(async (context, next) =>
            {
                await next();

                if (context.Response.StatusCode == 404 &&
                   !Path.HasExtension(context.Request.Path.Value) &&
                   !context.Request.Path.Value.StartsWith("/api/"))
                {
                    context.Request.Path = "/index.html";
                    await next();
                }
            });

            app.UseAuthentication();

            //app.UseHsts();

            //app.UseDefaultFiles();
            //app.UseAuthentication();
            app.UseCors("EnableCORS");
            //app.UseHttpsRedirection();

            //app.UseMvc();
            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("v1/swagger.json", "My API V1");
            //});
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc(p =>
            {
                p.EnableDependencyInjection();
                p.Select().Expand().Filter().OrderBy().MaxTop(100).Count();
              //  p.MapODataServiceRoute("odata", "odata", GetEdmModel());
            }
            );


        }
    }
}

   

   
  

