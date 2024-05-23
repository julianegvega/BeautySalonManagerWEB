using Microsoft.EntityFrameworkCore;
using BeautySalonManager.Models;

namespace BeautySalonManager.Data
{
    public class BeautySalonContext : DbContext
    {
        public BeautySalonContext(DbContextOptions<BeautySalonContext> options)
            : base(options)
        {
        }

        public DbSet<Servicio> Servicios { get; set; }
        // Define los DbSet para las otras entidades

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servicio>().HasNoKey();
        }
    }
}

