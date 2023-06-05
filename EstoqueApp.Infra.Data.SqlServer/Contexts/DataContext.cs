using EstoqueApp.Domain.Models;
using EstoqueApp.Infra.Data.SqlServer.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EstoqueApp.Infra.Data.SqlServer.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EstoqueConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        }

        public DbSet<Estoque>? Estoques { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
    }
}