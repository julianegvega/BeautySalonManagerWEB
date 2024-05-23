using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BeautySalonManager.Data;

namespace BeautySalonManager
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Este método se utiliza para agregar servicios al contenedor de inyección de dependencias.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BeautySalonContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BeautySalonConnection")));

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // Este método se utiliza para configurar el pipeline de solicitud HTTP.
        // Este método se utiliza para configurar el pipeline de solicitud HTTP.
        // Este método se utiliza para configurar el pipeline de solicitud HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, BeautySalonContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                context.Database.Migrate(); // Aplicar migraciones en entorno de desarrollo
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }


    }
}


