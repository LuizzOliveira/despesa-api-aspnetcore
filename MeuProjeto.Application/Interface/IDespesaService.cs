using MeuProjeto.Domain;

namespace MeuProjeto.Application.Interface;

public interface IDespesaService
{
    Task<List<Despesa>> ListarTodasAsync();
    Task AdicionarAsync(Despesa despesa);
}
