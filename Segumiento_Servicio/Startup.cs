using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Segumiento_Servicio.Models.BD;
using Segumiento_Servicio.Repository;
using Segumiento_Servicio.Service;

namespace Segumiento_Servicio
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
            services.AddControllers().AddNewtonsoftJson();


            //services.AddMemoryCache();
            // services.AddControllers();
            services.AddDistributedMemoryCache();
            services.AddSwaggerGen(c =>

            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Segumiento_Servicio", Version = "v1" });
            });

            services.AddDbContext<ContextDatabase>(

                options =>
                {
                    options.UseMySQL(Configuration["mysql:cn"]);
                });

            services.AddScoped<IServiceSeguimiento, ServiceSeguimiento>();
            services.AddScoped<IRepositorySeguimiento, RepositorySeguimiento>();
            services.AddScoped<IContextDatabase, ContextDatabase>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(options =>
            {
                options.WithOrigins("http://localhost:4200");
                options.AllowAnyMethod();
                options.AllowAnyHeader();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Segumiento_Servicio v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
