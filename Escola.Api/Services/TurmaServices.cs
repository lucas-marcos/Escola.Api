using Escola.Api.Data.Repositories.Interfaces;
using Escola.Api.Framework;
using Escola.Api.Models;
using Escola.Api.Services.Interfaces;

namespace Escola.Api.Services;

public class TurmaServices : ITurmaServices
{
    private readonly ITurmaRepository _turmaRepository;

    public TurmaServices(ITurmaRepository turmaRepository)
    {
        _turmaRepository = turmaRepository;
    }

    public Turma CadastraTurma(Turma turmaParaCadastrar)
    {
        _turmaRepository.Adicionar(turmaParaCadastrar);
        _turmaRepository.Salvar();

        return turmaParaCadastrar;
    }

    public Turma EditarTurma(Turma turmaParaEditar)
    {
        var turmaCadastrada = _turmaRepository.BuscarPorId(turmaParaEditar.Id) ?? throw new PontoIdException("Não foi possível encontrar a turma na base de dados");
        
        turmaCadastrada.Atualizar(turmaParaEditar);
        
        _turmaRepository.Atualizar(turmaCadastrada);
        _turmaRepository.Salvar();

        return turmaCadastrada;
    }

    public void DeletarTurma(int turmaId)
    {
        var turma = _turmaRepository.BuscarPorId(turmaId) ?? throw new PontoIdException("Não foi possível encontrar a turma");
        
        _turmaRepository.Remover(turmaId);
        _turmaRepository.Salvar();
    }
    
    public List<Turma> BuscarTodasTurmas() => _turmaRepository.BuscarTodosComIncludes().ToList();
    
}