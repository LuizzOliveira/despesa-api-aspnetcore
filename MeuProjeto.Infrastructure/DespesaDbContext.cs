using MeuProjeto.Domain;
using Microsoft.EntityFrameworkCore;

namespace MeuProjeto.Infrastructure;

public class DespesaDbContext(DbContextOptions<DespesaDbContext> op) : DbContext(op)
{
    public DbSet<Despesa> Despesas { get; set; }

    //desabilitar o pluralizador (estudar sobre)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Despesa>().ToTable("Despesas");
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Despesa>(entity =>
    //    {
    //        entity.ToTable("Despesas");
    //        entity.HasKey(e => e.Id);

    //        entity.Property(e => e.Valor)
    //              .HasPrecision(18, 2);

    //        entity.Property(e => e.Descricao)
    //              .IsRequired();
    //    });
    //}

}
