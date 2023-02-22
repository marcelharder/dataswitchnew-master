using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.code;
using api.data.implementations;
using api.data.interfaces;
using dataswitch.data.interfaces;
using dataswitch.Model;
using dataswitch.Model.maria_models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace dataswitch
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
            
            var _connectionString = Configuration.GetConnectionString("SQLConnection");
            services.AddDbContext<MariaContext>(options => options.UseMySql( _connectionString,ServerVersion.AutoDetect(_connectionString))); 
            services.AddDbContext<ecsur_kfafhContext>(x => x.UseSqlServer(Configuration.GetConnectionString("kfafhDatabase")));
            services.AddAutoMapper(System.Reflection.Assembly.GetExecutingAssembly());
            services.AddControllers();
            services.AddScoped<IMariaDBStuff, MariaDB>();
            services.AddScoped<IPatient, Patient>();
            services.AddTransient<specialMaps>(); 
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "dataswitch", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "dataswitch v1"));
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
