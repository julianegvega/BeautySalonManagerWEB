using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BeautySalonManager.Data;

namespace BeautySalonManager.Data
{
    public class BeautySalonManagerContext : DbContext
    {
        public BeautySalonManagerContext(DbContextOptions<BeautySalonManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
    }
}
