using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Contracts;
using Repository.Models;
using Repository.Repository;
using Service.Contracts;
using Service.Services;

namespace DublaPlay
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
            services.AddControllersWithViews();
            services.AddScoped(typeof(DublaPlayContexto));

            services.AddScoped<ICadastroRepository, CadastroRepository>();
            services.AddScoped<IAlteraRepository, AlteraRepository>();
            services.AddScoped<IBuscaRepository, BuscaRepository>();
            services.AddScoped<IDeletaRepository, DeletaRepository>();

            services.AddScoped<IDeletaService, DeletaService>();
            services.AddScoped<ICadastroService, CadastroService>();
            services.AddScoped<IAlteraService, AlteraService>();
            services.AddScoped<IBuscaService, BuscaService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
