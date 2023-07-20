using Escola.Api.Data.Repositories.Interfaces;
using Escola.Api.Framework;
using Escola.Api.Services.Interfaces;

namespace Escola.Api.Services;

public class EscolaServices : IEscolaServices
{
    private readonly IEscolaRepository _escolaRepository;

    public EscolaServices(IEscolaRepository escolaRepository)
    {
        _escolaRepository = escolaRepository;
    }

    public Models.Escola CadastrarEscola(Models.Escola escolaModel)
    {
        _escolaRepository.Adicionar(escolaModel);
        _escolaRepository.Salvar();

        return escolaModel;
    }

    public List<Models.Escola> RetornarTodasEscolas()
    {
        return _escolaRepository.BuscarTodos().ToList();
    }

    public void RemoverEscola(int escolaId)
    {
        var escola = _escolaRepository.BuscarPorId(escolaId) ?? throw new PontoIdException("Escola não encontrada");
        
        _escolaRepository.Remover(escolaId);
        _escolaRepository.Salvar();
    }
}