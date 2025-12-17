using MeuProjeto.Domain;
using Microsoft.EntityFrameworkCore;

namespace MeuProjeto.Infrastructure;

public class DespesaDbContext(DbContextOptions<DespesaDbContext> op) : DbContext(op)
{
    public DbSet<Despesa> Despesas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Despesa>().ToTable("Despesas");
    }
}
