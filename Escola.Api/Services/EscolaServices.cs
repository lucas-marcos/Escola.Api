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

    public Models.Escola EditarEscola(Models.Escola escolaParaAtualizar)
    {
        var escola = _escolaRepository.BuscarPorId(escolaParaAtualizar.Id) ?? throw new PontoIdException("Escola não encontrada");

        escola.Atualizar(escolaParaAtualizar);
        
        _escolaRepository.Atualizar(escola);
        _escolaRepository.Salvar();

        return escola;
    }
}