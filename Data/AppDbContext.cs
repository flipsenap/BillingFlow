using BillingFlowApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BillingFlowApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cobranca> Cobrancas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Cobranca>()
                .Property(c => c.Valor)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Pagamento>()
                .Property(p => p.Valor)
                .HasPrecision(10, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}