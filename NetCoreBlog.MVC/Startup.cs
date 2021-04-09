using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetBlog.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreBlog.BLL.Abstract;
using NetCoreBlog.BLL.Repository;

namespace NetCoreBlog.MVC
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x=>x.EnableEndpointRouting=false);
            //install-package Microsoft.EntityFrameworkCore.SqlServer kütüphanesini ekliyoruz.
            services.AddDbContext<BlogDbContext>(x=>x.UseSqlServer(@"server=.\SQLEXPRESS01;database=NetCoreBlogDB;uid=sa;pwd=123",b=>b.MigrationsAssembly("NetCoreBlog.MVC")));
            services.AddTransient<IBlogRepository,BlogRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

        }    
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
            app.UseMvc(route =>
            {
                route.MapRoute(
                    name: "areas", 
                    template: "{area:exists}/{Controller=Home}/{Action=Index}/{id?}"
                    );

                route.MapRoute(
                    name: "default",
                    template: "{Controller=Home}/{Action=Index}/{id?}"
                    );
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
