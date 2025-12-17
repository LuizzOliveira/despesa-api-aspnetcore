// MeuProjeto.Application/Services/DespesaService.cs
using MeuProjeto.Application.Interface;
using MeuProjeto.Domain;
using MeuProjeto.Infrastructure.Interface;

namespace MeuProjeto.Application.Services
{
    public class DespesaService : IDespesaService
    {
        private readonly IDespesaRepository _repository;

        public DespesaService(IDespesaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Despesa>> ListarTodasAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task AdicionarAsync(Despesa despesa)
        {
            if (despesa.Valor <= 0)
            {
                throw new ArgumentException("O valor da despesa deve ser positivo.");
            }

            await _repository.AddAsync(despesa);
        }
    }
}