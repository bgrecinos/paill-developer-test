using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PaillApp.Data;
using PaillApp.Repositories;
using PaillApp.Repositories.Interfaces;
using PaillApp.Services;
using PaillApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaillApp
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

            services.AddTransient<IAreaRepository, AreaRepository>();
            services.AddTransient<IEmpleadoRepository, EmpleadoRepository>();
            services.AddTransient<IEmpleadoHabilidadRepository, EmpleadoHabilidadRepository>();

            services.AddTransient<IAreaServices, AreaService>();
            services.AddTransient<IEmpleadoService, EmpleadoService>();
            services.AddTransient<IEmpleadoHabilidadService, EmpleadoHabilidadService>();
            
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddDbContext<PaillContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("PaillConnection"))
            );
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
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
