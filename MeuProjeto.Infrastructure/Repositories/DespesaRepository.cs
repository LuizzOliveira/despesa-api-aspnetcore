using MeuProjeto.Domain;
using MeuProjeto.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace MeuProjeto.Infrastructure.Repositories;

public class DespesaRepository(DespesaDbContext context) : IDespesaRepository
{
    public readonly DespesaDbContext _context = context;

    public async Task AddAsync(Despesa despesa)
    {
        await _context.Despesas.AddAsync(despesa);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Despesa>> GetAllAsync()
    {
        return _context.Despesas.ToList();
    }
}
