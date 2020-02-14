﻿
using Management.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Raketero.Core.Repositories;
using Raketero.Core.Services;
using Raketero.Core.Services.Concrete;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.Swagger;
using System;

namespace raketero_api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IConfigurationRoot ConfigurationRoot { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var builder = new ConfigurationBuilder()
           .SetBasePath(Environment.CurrentDirectory)
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            ConfigurationRoot = builder.Build();

            var TestConstring = ConfigurationRoot.GetSection("Logging:ConnectionString:Test");
            var constring = TestConstring.Value;

            var resourceFactory = new MySqlResourceFactory<SearchRepository>(constring);

            services.AddTransient(typeof(IRepositoryResourceFactory<string, MySqlUnitOfWork>), p => resourceFactory);
            services.AddTransient<ISearchService, SearchService<string, MySqlUnitOfWork>>();


            #region Swagger
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Raketero API",
                        Description = "Web service for raketero web and mobile",
                        Version = "1.0.0"
                    });
            });
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            #region swagger

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "Raketero API");
            });

            #endregion

            app.UseMvc();
        }
    }
}
