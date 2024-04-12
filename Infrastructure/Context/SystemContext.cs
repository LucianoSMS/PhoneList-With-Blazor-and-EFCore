using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class SystemContext : DbContext
    {
        internal object Contact;

        public SystemContext( DbContextOptions<SystemContext> options): base (options) { }

        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SystemContext).Assembly);
        }
    }
}
