using MeuProjeto.Domain;

namespace MeuProjeto.Infrastructure.Interface;

public interface IDespesaRepository
{
    Task<List<Despesa>> GetAllAsync();
    Task AddAsync(Despesa despesa);
}
